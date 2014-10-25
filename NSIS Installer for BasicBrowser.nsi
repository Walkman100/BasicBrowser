; BasicBrowser Installer NSIS Script
; get NSIS at http://tenet.dl.sourceforge.net/project/nsis/NSIS%202/2.46/nsis-2.46-setup.exe
; As a program that all Power PC users should have, Notepad ++ is recommended to edit this file

;AddBrandingImage top 20
;Icon youtube_withLink.ico
Caption "BasicBrowser(Gecko) Installer"
Name "BasicBrowser(Gecko)"
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing BasicBrowser. If you understand the notice, click the checkbox below and click Next."

InstallDir $PROGRAMFILES\DeavmiOSS\BasicBrowser(Gecko)

OutFile "bin\Release\BasicBrowser-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "Executable, Uninstaller & DLLs"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\BasicBrowser.exe"
  WriteUninstaller "BasicBrowser(Gecko)-Uninst.exe"
  
  ; DLLs
  File "bin\Release\*.dll"
  ; Sub-Folders
  File /r "bin\Release\chrome"
  File /r "bin\Release\components"
  File /r "bin\Release\defaults"
  File /r "bin\Release\dictionaries"
  File /r "bin\Release\greprefs"
  File /r "bin\Release\modules"
  File /r "bin\Release\plugins"
  File /r "bin\Release\res"
SectionEnd

Section "Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\BasicBrowser(Gecko).lnk" "$INSTDIR\BasicBrowser.exe" "" "$INSTDIR\BasicBrowser.exe" "" "" "" "BasicBrowser(Gecko)"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall BasicBrowser(Gecko).lnk" "$INSTDIR\BasicBrowser(Gecko)-Uninst.exe" "" "" "" "" "" "Uninstall BasicBrowser(Gecko)"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "Desktop Shortcut"
  CreateShortCut "$DESKTOP\BasicBrowser(Gecko).lnk" "$INSTDIR\BasicBrowser.exe" "" "$INSTDIR\BasicBrowser.exe" "" "" "" "BasicBrowser(Gecko)"
SectionEnd

Section "Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\BasicBrowser(Gecko).lnk" "$INSTDIR\BasicBrowser.exe" "" "$INSTDIR\BasicBrowser.exe" "" "" "" "BasicBrowser(Gecko)"
SectionEnd

SubSection "Open in BasicBrowser(Gecko)"
  Section "Add to Open With menu"
    WriteRegStr HKCR "Applications\BasicBrowser(Gecko).exe\shell\open\command" "" "$\"$INSTDIR\BasicBrowser.exe$\" $\"%1$\""
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.html\OpenWithList" "k" "BasicBrowser(Gecko).exe"
  SectionEnd
  
  Section "Set as default program"
    WriteRegStr HKCR "Applications\BasicBrowser(Gecko).exe\shell\open\command" "" "$\"$INSTDIR\BasicBrowser.exe$\" $\"%1$\""
    WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.html\UserChoice" "Progid" "Applications\BasicBrowser(Gecko).exe"
  SectionEnd
  
SubSectionEnd

;Section "More apps from DeavmiOSS"
; this should have sub options for available apps, that are downloaded
;SectionEnd

; Uninstaller

Section "Uninstall"
  Delete $INSTDIR\BasicBrowser(Gecko)-Uninst.exe   ; Remove Application Files
  Delete $INSTDIR\BasicBrowser.exe
  RMDir $INSTDIR
  
  Delete $SMPROGRAMS\DeavmiOSS\BasicBrowser(Gecko).lnk   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall BasicBrowser(Gecko).lnk"
  RMDir $SMPROGRAMS\DeavmiOSS
  
  Delete $DESKTOP\BasicBrowser(Gecko).lnk   ; Remove Desktop Shortcut
  Delete $QUICKLAUNCH\BasicBrowser(Gecko).lnk   ; Remove Quick Launch Shortcut
  
  DeleteRegKey HKCR Applications\BasicBrowser(Gecko).exe ; Remove open with association
  DeleteRegValue HKCU "Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.html\OpenWithList" "k"
  WriteRegStr HKCU "Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.html\UserChoice" "Progid" "Applications\chrome.exe"
SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install BasicBrowser(Gecko). Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  ;SetBrandingImage "[/RESIZETOFIT] youtube_withLink.ico"
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/Walkman100/BasicBrowser/blob/gecko/README.md#basicbrowser-"
    NoReadme:
FunctionEnd

; Uninstaller

Function un.onInit
    MessageBox MB_YESNO "This will uninstall BasicBrowser(Gecko). Continue?" IDYES NoAbort
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
