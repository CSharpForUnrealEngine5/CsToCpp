namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimTypes.h")]
///<summary>Indicates whether an animation is additive, and what kind.</summary>
public enum EAdditiveAnimationType {
	AAT_None=0,
	AAT_LocalSpaceBase=1,
	AAT_RotationOffsetMeshSpace=2,
	AAT_MAX=3,
}
