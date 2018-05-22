echo off
set curDir=%cd%
set unity="%PROGRAMFILES%/Unity/Editor/Unity.exe"

set projectPath=%1
set build_name=%~n1

echo "build name = " %build_name%

set win64=-buildWindows64Player %cd%\..\..\Bin\%build_name%\win64\%build_name%.exe

echo building %build_name% to %cd%\build\%build_name%\win64\%build_name%.exe
%unity% -batchmode -quit -projectPath %projectPath%  %win64%

cd %curDir%