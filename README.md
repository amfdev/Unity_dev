# Unity Dev
Examples that demonstrate Unity game integration with some of the libraries and SDKs available on GPUOpen.

---

### AmfUnityPlugin
AmfUnityPlugin is a plugin using the Advanced Media Framework (AMF) SDK for hardware accelerated video and audio playback on AMD GPUs in Unity. Two modes of operation are supported with this example: normal video playback and 360 video playback(mono and stereoscopic).  For audio, the plugin supports ambisonic sound. Information and instructions for this plugin is included in a README file and also in the .cs script documentation.

### Requirements:
* [Same as AMF](https://github.com/GPUOpen-LibrariesAndSDKs/AMF) 
* Unity(https://store.unity.com/download?ref=personal)
* Git
* Mercurial. If Mercurial is not available then download the files manually and copy the headers from "https://bitbucket.org/Unity-Technologies/graphicsdemos/src/default/NativeRenderingPlugin/PluginSource/source/Unity/" to the UnityIntegrations/AMFUnityPlugin/source/Unity directory AFTER executing Scripts/fetch_all.bat.
* Stereoscopic 360 video playback requires a fix available in a recent release of Unity (5.6.1p3 or later)

---

### Getting Started
* Prepare AMFUnityPlugin by executing Scripts/fetch_all.bat.
* Build Plugin by executing Scripts/build_plugin.bat or build_all(with samples)

### Posible problems
* build_plugin using Visual Studio 2017 Community edition and v140 toolset, in other cases you need to specify it in the begining of the file.
* if unity installed in custom location, you need to specify this location in Samples/build_unity_project.bat
* there are 3 project files in \UnityIntegrations\AmfUnityPlugin\source\AMF\amf\public\samples CPPSamples_vs2013.sln CPPSamples_vs2015.sln CPPSamples_vs2017.sln. Now script configured to use CPPSamples_vs2015. If you want to change it, you nead to replace "project" variable in  Scripts/build_plugin.bat and "vsVersion" in  Scripts/AMFUnityPlugin/makeDist.cmd

### Attribution
- AMD, the AMD Arrow logo, and combinations thereof are either registered trademarks or trademarks of Advanced Micro Devices, Inc. in the United States and/or other countries.
- Microsoft, Visual Studio are either registered trademarks or trademarks of Microsoft Corporation in the United States and/or other countries.
- Unity is a trademark of Unity Technologies.
