echo off
set curDir=%cd%

set build_name=%1

echo "clear build " %build_name%
cd %build_name%

::clear additional unity files
rmdir /S /Q build
rmdir /S /Q Packages
::clear build files
rmdir /S /Q Mono
rmdir /S /Q Temp
rmdir /S /Q %build_name%_Data
del %build_name%.exe
del UnityCrashHandler64.exe
del UnityPlayer.dll


cd Library
::clear additional unity files
rmdir /S /Q metadata
rmdir /S /Q PlayerDataCache
rmdir /S /Q ScriptAssemblies
rmdir /S /Q ShaderCache

del assetDatabase3

cd curDir