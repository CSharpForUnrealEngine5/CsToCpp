namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/Skeleton.h")]
///<summary>Bone translation retargeting mode.</summary>
[CppEnumInNamespace]
public enum EBoneTranslationRetargetingMode {
	Animation=0,
	Skeleton=1,
	AnimationScaled=2,
	AnimationRelative=3,
	OrientAndScale=4,
}
