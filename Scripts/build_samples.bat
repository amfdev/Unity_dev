set curDir=%cd%

cd AMFUnityPlugin
call makeDist.cmd

cd ../../Samples
call build_unity_project.bat Bilboard

call dist2Proj.cmd Bilboard_AMF
call build_unity_project.bat Bilboard_AMF

call dist2Proj.cmd Sphere_AMF
call build_unity_project.bat Sphere_AMF

call dist2Proj.cmd SkySphere_AMF
call build_unity_project.bat SkySphere_AMF

cd %curDir%
