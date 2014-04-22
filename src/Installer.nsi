; OSPA ProgDev
; Copyright (C) 2014 Brian Luft
; 
; This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public 
; License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later
; version.
; 
; This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied 
; warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more 
; details.
; 
; You should have received a copy of the GNU General Public License along with this program; if not, write to the Free
; Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.

Name "OSPA ProgDev"
OutFile "ProgDev-X.X.X.exe"
InstallDir $PROGRAMFILES\OSPA

InstallDirRegKey HKLM "Software\OSPA" "Install_Dir"

RequestExecutionLevel admin

;--------------------------------

Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------

; The stuff to install
Section "OSPA"

   SectionIn RO
  
   SetOutPath $INSTDIR
  
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\Antlr4.Runtime.v4.5.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\FSharp.Core.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ICSharpCode.TextEditor.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\MimeKitLite.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\PDC.exe"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.exe"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev App Icon 32.ico"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.BusinessLogic.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.Domain.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.exe.config"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.exe.manifest"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.FrontEnd.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.Parsers.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.Resources.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\ProgDev.Services.dll"
   File "ProgDev\bin\Release\app.publish\Application Files\ProgDev_1_0_0_0\WeifenLuo.WinFormsUI.dll"

   ; Start menu
   CreateDirectory "$SMPROGRAMS\OSPA"
   CreateShortCut "$SMPROGRAMS\OSPA\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
   CreateShortCut "$SMPROGRAMS\OSPA\OSPA ProgDev.lnk" "$INSTDIR\ProgDev.exe" "" "$INSTDIR\ProgDev.exe" 0
  
   ; Write the installation path into the registry
   WriteRegStr HKLM SOFTWARE\OSPA "Install_Dir" "$INSTDIR"

   ; Write the uninstall keys for Windows
   WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\OSPA" \
      "DisplayName" "OSPA ProgDev"
   WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\OSPA" \
      "Publisher" "Open Source PLC Architecture"
   WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\OSPA" \
      "DisplayIcon" "$INSTDIR\ProgDev App Icon 32.ico"
   WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\OSPA" \
      "URLInfoAbout" "https://github.com/electroly/ospa"
   WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\OSPA" \
      "UninstallString" '"$INSTDIR\uninstall.exe"'
   WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\OSPA" \
      "NoModify" 1
   WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\OSPA" \
      "NoRepair" 1
   
   WriteUninstaller "uninstall.exe"
  
SectionEnd

;--------------------------------

; Uninstaller

Section "Uninstall"
  
   ; Remove registry keys
   DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\OSPA"
   DeleteRegKey HKLM SOFTWARE\OSPA

   ; Remove files and uninstaller
   Delete $INSTDIR\uninstall.exe
   Delete $INSTDIR\*.*

   ; Remove shortcuts, if any
   Delete "$SMPROGRAMS\OSPA\*.*"

   ; Remove directories used
   RMDir "$SMPROGRAMS\OSPA"
   RMDir "$INSTDIR"

SectionEnd
