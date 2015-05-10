@ECHO OFF
IF NOT [%1] == [] GOTO Param

SET /P message=Choose change summary: 
GOTO Start

:Param
set message=%1

:Start
git add .
git commit -a -m %message%
git push -u origin master

PAUSE