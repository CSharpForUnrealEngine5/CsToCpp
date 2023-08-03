#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier.h")]
public partial class URootMotionModifier_Warp : URootMotionModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Name used to find the warp target for this modifier</summary>
	public string WarpTargetName;
	///<summary>WarpPointAnimProvider</summary>
	public EWarpPointAnimProvider WarpPointAnimProvider;
	///<summary>@TODO: Hide from the UI when Target != Static</summary>
	public FTransform WarpPointAnimTransform;
	///<summary>@TODO: Hide from the UI when Target != Bone</summary>
	public string WarpPointAnimBoneName;
	///<summary>Whether to warp the translation component of the root motion</summary>
	public bool bWarpTranslation;
	///<summary>Whether to ignore the Z component of the translation. Z motion will remain untouched</summary>
	public bool bIgnoreZAxis;
	///<summary>Easing function used when adding translation. Only relevant when there is no translation in the animation</summary>
	public EAlphaBlendOption AddTranslationEasingFunc;
	///<summary>Custom curve used to add translation when there is none to warp. Only relevant when AddTranslationEasingFunc is set to Custom</summary>
	public UCurveFloat AddTranslationEasingCurve;
	///<summary>Whether to warp the rotation component of the root motion</summary>
	public bool bWarpRotation;
	///<summary>Whether rotation should be warp to match the rotation of the sync point or to face the sync point</summary>
	public EMotionWarpRotationType RotationType;
	///<summary>Allow to modify how fast the rotation is warped.</summary>
	public float WarpRotationTimeMultiplier;
	///<summary>CachedTargetTransform</summary>
	public FTransform CachedTargetTransform;
}
