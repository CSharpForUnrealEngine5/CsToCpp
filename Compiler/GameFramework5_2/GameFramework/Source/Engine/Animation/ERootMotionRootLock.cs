namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimEnums.h")]
///<summary>Root Bone Lock options when extracting Root Motion.</summary>
[CppEnumInNamespace]
public enum ERootMotionRootLock {
	RefPose=0,
	AnimFirstFrame=1,
	Zero=2,
}
