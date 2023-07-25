#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayTypes.h")]
///<summary>Enumeration of results from Connecting to Remote XR device</summary>
[CppEnumInNamespace]
public enum EXRDeviceConnectionResult {
	NoTrackingSystem=0,
	FeatureNotSupported=1,
	NoValidViewport=2,
	MiscFailure=3,
	Success=4,
}
