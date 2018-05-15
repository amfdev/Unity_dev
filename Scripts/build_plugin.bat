set msbuild="C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\msbuild.exe"
set toolset=v140
set project=CPPSamples_vs2015.sln

set curDir=%cd%

::build AMF
cd ..\UnityIntegrations\AmfUnityPlugin\source\AMF\amf\public\samples
%msbuild% %project% /property:Configuration=Release /property:Platform=x64 /m

::build AmfUnityPlugin
cd ..\..\..\..\..\
%msbuild% AmfUnityPlugin.sln /property:Configuration=Release /property:Platform=x64 /p:PlatformToolset=%toolset% /m

cd %curDir%