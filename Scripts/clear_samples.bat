set curDir=%cd%

cd ..
rmdir /S /Q Bin

cd Scripts/Samples
call clean_unity_project.bat %cd%/../../Samples/VideoPlayBackSample

cd %curDir%
