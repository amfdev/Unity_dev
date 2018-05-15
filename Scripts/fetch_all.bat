set curDir=%cd%

cd ..
rmdir /S /Q UnityIntegrations
git clone https://github.com/GPUOpen-LibrariesAndSDKs/UnityIntegrations.git

cd UnityIntegrations/AmfUnityPlugin

call prepareUnity.cmd
cd %curDir%
