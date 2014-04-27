call "C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\Tools\VsDevCmd.bat"
if exist ProgDev-X.X.X.exe ( del /F ProgDev-X.X.X.exe )
msbuild /target:clean /p:Configuration=Release /verbosity:q /nologo
msbuild /target:build /p:Configuration=Release /verbosity:q /nologo
pushd ProgDev
msbuild /target:publish /p:Configuration=Release /verbosity:q /nologo
popd
"C:\Program Files (x86)\NSIS\makensis.exe" /V3 Installer.nsi
