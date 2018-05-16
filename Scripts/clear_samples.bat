set curDir=%cd%

cd ../Samples
rmdir /S /Q build
rmdir /S /Q dist

call clean_unity_project.bat Bilboard
call clean_unity_project.bat Bilboard_AMF
call clean_unity_project.bat Sphere_AMF
call clean_unity_project.bat SkySphere_AMF

cd %curDir%
