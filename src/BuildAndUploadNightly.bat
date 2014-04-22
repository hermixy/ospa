@echo off
prompt $
@echo on
if exist ProgDev-X.X.X.exe (
   del ProgDev-X.X.X.exe
)
if exist ProgDev-nightly.exe (
   del ProgDev-nightly.exe
)
call BuildInstaller.bat
if exist ProgDev-X.X.X.exe (
   ren ProgDev-X.X.X.exe ProgDev-nightly.exe
   call AuthenticateToS3.bat
   "..\external\s3\s3.exe" put "ospa.co" ProgDev-nightly.exe /acl:public-read
)
