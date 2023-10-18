namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSessionConfig.h")]
///<summary>Options for how the Unreal frame synchronizes with camera image updates. This feature is used by ARCore.</summary>
public enum EARFrameSyncMode {
	SyncTickWithCameraImage=0,
	SyncTickWithoutCameraImage=1,
}
