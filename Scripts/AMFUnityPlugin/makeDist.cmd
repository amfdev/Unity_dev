echo off
set curDir=%cd%

set vsVersion=vs2015
cd ../../Samples/
set dist=.\dist
if exist "%dist%" (
	echo Cleaning %dist% directory
	if exist %dist%\*.dll del %dist%\*.dll
	if exist %dist%\*.cs del %dist%\*.cs
) else (
	mkdir %dist%
)

set plugin=..\UnityIntegrations\AmfUnityPlugin\bin\x64\Release\AmfUnityPlugin.dll
set dbgplugin=..\UnityIntegrations\AmfUnityPlugin\bin\x64\Debug\AmfUnityPlugin.dll

if exist "%plugin%" (
	echo Copying Release plugin
	copy %plugin% %dist%
) else (
	if exist "%dbgplugin%" ( 
		echo Copying Debug plugin
		copy %dbgplugin% %dist%
	) else (
		echo Plugin has not been built.
	)
)

set dlldir=..\UnityIntegrations\AmfUnityPlugin\source\AMF\amf\bin\%vsVersion%x64Release\
set dbgdlldir=..\UnityIntegrations\AmfUnityPlugin\source\AMF\amf\bin\%vsVersion%x64Debug\
if exist "%dlldir%" (
	copy "%dlldir%\amf-component-ffmpeg64.dll" %dist%
	copy "%dlldir%\avcodec-57.dll" %dist%
	copy "%dlldir%\avformat-57.dll" %dist%
	copy "%dlldir%\avresample-3.dll" %dist%
	copy "%dlldir%\avutil-55.dll" %dist%
	copy "%dlldir%\swresample-2.dll" %dist%
	copy "%dlldir%\avresample-3.dll" %dist%
) else (
	if exist "%dbgdlldir%" (
	copy "%dbgdlldir%\amf-component-ffmpeg64.dll" %dist%
	copy "%dbgdlldir%\avcodec-57.dll" %dist%
	copy "%dbgdlldir%\avformat-57.dll" %dist%
	copy "%dbgdlldir%\avresample-3.dll" %dist%
	copy "%dbgdlldir%\avutil-55.dll" %dist%
	copy "%dbgdlldir%\swresample-2.dll" %dist%
	copy "%dbgdlldir%\avresample-3.dll" %dist%
	) else (
		echo FFMPEG DLL directory has not been created.
	)
)

::copy %curDir%\AmfUnityPlugin.cs %dist%
:: copy %curDir%\Amf360UnityPlugin.cs %dist%

cd %curDir%

