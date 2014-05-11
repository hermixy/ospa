@echo off

echo === OSPA ProgDev Build ===

set VSDIR=C:\Program Files (x86)\Microsoft Visual Studio 12.0
set WIXDIR=C:\Program Files (x86)\WiX Toolset v3.8\bin
set WORKDIR=%TEMP%\ProgDevBuild

call "%VSDIR%\Common7\Tools\VsDevCmd.bat"
if exist "%WORKDIR%" ( rmdir /S /Q "%WORKDIR%" )
mkdir "%WORKDIR%"

echo --- Clean solution ---
   msbuild /target:clean /p:Configuration=Release /verbosity:q /nologo

echo --- Build solution ---
   msbuild /target:build /p:Configuration=Release /verbosity:q /nologo

echo --- Publish project ---
   pushd ProgDev
      msbuild /target:publish /p:Configuration=Release /verbosity:q /nologo
   popd

echo --- Copy release files ---
   copy ProgDev.wxs "%WORKDIR%"
   pushd "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0"
      copy *.* "%WORKDIR%"
   popd

echo --- Build installer ---
   pushd "%WORKDIR%"
      "%WIXDIR%\candle.exe" -nologo -pedantic ProgDev.wxs
      if exist ProgDev.wixobj ( "%WIXDIR%\light.exe" -nologo -pedantic ProgDev.wixobj )
   popd
   if exist ProgDev.msi ( del /F /Q ProgDev.msi )
   copy "%WORKDIR%\ProgDev.msi" .
   rmdir /S /Q "%WORKDIR%"

echo --- Result ---
   if exist ProgDev.msi ( echo Build successful. ) else ( echo Build failed. )
