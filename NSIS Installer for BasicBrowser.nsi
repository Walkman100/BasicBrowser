; BasicBrowser Installer NSIS Script
; get NSIS at http://tenet.dl.sourceforge.net/project/nsis/NSIS%202/2.46/nsis-2.46-setup.exe
; As a program that all Power PC users should have, Notepad ++ is recommended to edit this file

;AddBrandingImage top 20
;Icon youtube_withLink.ico
Caption "BasicBrowser Installer"
Name "BasicBrowser"
AutoCloseWindow true

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing BasicBrowser. If you understand the notice, click the checkbox below and click Next."

InstallDir $PROGRAMFILES\DeavmiOSS

OutFile "bin\Release\BasicBrowser-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "BasicBrowser Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\BasicBrowser.exe"
  WriteUninstaller "BasicBrowser-Uninst.exe"
SectionEnd

Section "BasicBrowser Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\BasicBrowser.lnk" "$INSTDIR\BasicBrowser.exe" "" "$INSTDIR\BasicBrowser.exe" "" "" "" "BasicBrowser"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall BasicBrowser.lnk" "$INSTDIR\BasicBrowser-Uninst.exe" "" "" "" "" "" "Uninstall BasicBrowser"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "BasicBrowser Desktop Shortcut"
  CreateShortCut "$DESKTOP\BasicBrowser.lnk" "$INSTDIR\BasicBrowser.exe" "" "$INSTDIR\BasicBrowser.exe" "" "" "" "BasicBrowser"
SectionEnd

Section "BasicBrowser Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\BasicBrowser.lnk" "$INSTDIR\BasicBrowser.exe" "" "$INSTDIR\BasicBrowser.exe" "" "" "" "BasicBrowser"
SectionEnd

;Section "More apps from DeavmiOSS"
; this should have sub options for available apps, that are downloaded
;SectionEnd

; Uninstaller

Section "Uninstall"
  Delete $INSTDIR\BasicBrowser-Uninst.exe   ; Remove Application Files
  Delete $INSTDIR\BasicBrowser.exe
  RMDir $INSTDIR
  
  Delete $SMPROGRAMS\DeavmiOSS\BasicBrowser.lnk   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall BasicBrowser.lnk"
  RMDir $SMPROGRAMS\DeavmiOSS
  
  Delete $DESKTOP\BasicBrowser.lnk   ; Remove Desktop Shortcut
  Delete $QUICKLAUNCH\BasicBrowser.lnk   ; Remove Quick Launch shortcut
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install BasicBrowser. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  ;SetBrandingImage "[/RESIZETOFIT] youtube_withLink.ico"
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/BasicBrowser/blob/master/README.md#basicbrowser-"
    NoReadme:
FunctionEnd

; Uninstaller

Function un.onInit
    MessageBox MB_YESNO "This will uninstall BasicBrowser. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd
