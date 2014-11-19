@echo off

%ProgramFiles%\MSBuild\12.0\bin\msbuild.exe /property:Configuration=Release BasicBrowser.sln

%ProgramFiles%\NSIS\makensis.exe "NSIS Installer for BasicBrowser.nsi"

rem use this if you want it to ask where to rar to
rem %ProgramFiles%\WinRAR\WinRAR.exe a -ep1 -scul -r0 -iext --. %~dp0bin\Release\BasicBrowser.exe

%ProgramFiles%\WinRAR\WinRAR.exe a -ep1 -scul -r0 -iext -- %~dp0bin\Release\BasicBrowser-Portable.rar %~dp0bin\Release\BasicBrowser.exe

explorer.exe "%~dp0bin\Release"