set curDir=%cd%

cd Samples
call makeDist.cmd

call dist2Proj.cmd %curDir%/../../Samples/VideoPlayBackSample
call build_unity_project.bat %curDir%/../../Samples/VideoPlayBackSample

cd %curDir%
