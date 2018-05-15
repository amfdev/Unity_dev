echo off
set curDir=%cd%
set unity="%PROGRAMFILES%/Unity/Editor/Unity.exe"

set build_name=%1

echo "build name = " %build_name%

set win64=-buildWindows64Player %cd%\build\%build_name%\win64\%build_name%.exe

echo building %build_name% to %cd%\build\%build_name%\win64\%build_name%.exe
%unity% -batchmode -quit -projectPath %cd%\%build_name%  %win64%

cd curDir