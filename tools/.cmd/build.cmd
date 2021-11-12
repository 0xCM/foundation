@echo off
call %~dp0..\..\.cmd\config.cmd

dotnet build %ToolProjPath% -c Release