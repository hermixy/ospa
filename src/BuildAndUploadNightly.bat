if exist ProgDev-nightly.exe ( del /F ProgDev-nightly.exe )
call Build.bat
if exist ProgDev-X.X.X.exe (
   ren ProgDev-X.X.X.exe ProgDev-nightly.exe
   call AuthenticateToS3.bat
   "..\external\s3\s3.exe" put "ospa.co" ProgDev-nightly.exe /acl:public-read
)
