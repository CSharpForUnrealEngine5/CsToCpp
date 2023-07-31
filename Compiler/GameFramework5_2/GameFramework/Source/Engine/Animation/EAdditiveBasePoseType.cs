#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimEnums.h")]
///<summary>For an additive animation, indicates what the animation is relative to.</summary>
public enum EAdditiveBasePoseType {
	ABPT_None=0,
	ABPT_RefPose=1,
	ABPT_AnimScaled=2,
	ABPT_AnimFrame=3,
	ABPT_LocalAnimFrame=4,
	ABPT_MAX=5,
}
