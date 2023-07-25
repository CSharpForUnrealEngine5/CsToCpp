#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayTypes.h")]
///<summary>Flags to better inform the user about specifics of the underlying XR system</summary>
public enum EXRSystemFlags {
	NoFlags=0,
	IsAR=1,
	IsTablet=2,
	IsHeadMounted=4,
	SupportsHandTracking=8,
}
