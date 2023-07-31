#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure encapsulating animated (bone) attribute data.</summary>
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
public partial struct FAnimatedBoneAttribute {
	public FAnimationAttributeIdentifier Identifier;
	public FAttributeCurve Curve;
}
