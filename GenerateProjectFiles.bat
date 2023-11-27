echo off

del *.sln
rmdir /s /q .vs
rmdir /s /q Binaries
rmdir /s /q Intermediate
rem rmdir /s /q Saved
rmdir /s /q DerivedDataCache


set MyUVS="E:\UnrealEngine-5.3\Engine\Binaries\Win64\UnrealVersionSelector-Win64-Shipping.exe"
set MyUBT="E:\UnrealEngine-5.3\Engine\Binaries\DotNET\UnrealBuildTool\UnrealBuildTool.exe"

rem change Transformation to your own project name
set MyFullPath="%cd%\CGVDemo"


%MyUVS% /projectfiles %MyFullPath%.uproject

%MyUBT% Development Win64 -Project=%MyFullPath%.uproject -TargetType=Editor -Progress -NoHotReloadFromIDE

%MyFullPath%.uproject

%MyFullPath%.sln