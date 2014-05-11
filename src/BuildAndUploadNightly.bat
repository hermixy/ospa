@echo off
if exist ProgDev.msi ( del /F ProgDev.msi )
if exist ProgDev-nightly.msi ( del /F ProgDev-nightly.msi )
call Build.bat
if exist ProgDev.msi (
   ren ProgDev.msi ProgDev-nightly.msi
   call AuthenticateToS3.bat
   "..\external\s3\s3.exe" put "ospa.co" ProgDev-nightly.msi /acl:public-read
)
