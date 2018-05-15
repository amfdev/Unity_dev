set curDir=%cd%

cd ../Samples
rmdir /S /Q build
call build_unity_project.bat Bilboard

cd %curDir%