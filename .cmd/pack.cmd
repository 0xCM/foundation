@echo off
call %~dp0config.cmd

dotnet pack %SlnPath% -c Release --output %PkgDst%
