@echo off
call %~dp0config.cmd

dotnet pack %SlnPath% -c Release --include-symbols --include-source --output %PkgDst%
