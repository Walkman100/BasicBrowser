@echo off

"%ProgramFiles%\MSBuild\12.0\bin\msbuild.exe" /property:Configuration=Release BasicBrowser.sln

"%ProgramFiles%\NSIS\makensis.exe" "NSIS Installer for BasicBrowser.nsi"
del bin\Release\BasicBrowser-Portable.exe
ren bin\Release\BasicBrowser.exe BasicBrowser-Portable.exe

explorer.exe "%~dp0bin\Release"