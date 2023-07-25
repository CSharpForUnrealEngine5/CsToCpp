#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier.h")]
public partial class URootMotionModifier_Warp : URootMotionModifier {
// RootMotionModifier_Warp
	public string WarpTargetName;
	public EWarpPointAnimProvider WarpPointAnimProvider;
	public FTransform WarpPointAnimTransform;
	public string WarpPointAnimBoneName;
	public bool bWarpTranslation;
	public bool bIgnoreZAxis;
	public EAlphaBlendOption AddTranslationEasingFunc;
	public UCurveFloat AddTranslationEasingCurve;
	public bool bWarpRotation;
	public EMotionWarpRotationType RotationType;
	public float WarpRotationTimeMultiplier;
	public FTransform CachedTargetTransform;
}
