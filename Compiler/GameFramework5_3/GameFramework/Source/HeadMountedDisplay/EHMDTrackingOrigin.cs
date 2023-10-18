namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayTypes.h")]
///<summary>For HMDs that support it, this specifies whether the origin of the tracking universe will be at the floor, or at the user&#39;s eye height</summary>
[CppEnumInNamespace]
public enum EHMDTrackingOrigin {
	Floor=0,
	Eye=1,
	Stage=2,
}
