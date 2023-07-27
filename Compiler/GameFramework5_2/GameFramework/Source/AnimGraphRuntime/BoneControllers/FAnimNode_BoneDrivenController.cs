#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_BoneDrivenController.h")]
///<summary>This is the runtime version of a bone driven controller, which maps part of the state from one bone to another (e.g., 2 * source.x -> target.z)</summary>
public partial struct FAnimNode_BoneDrivenController {
// AnimNode_BoneDrivenController
	public FBoneReference SourceBone;
	public UCurveFloat DrivingCurve;
	public float Multiplier;
	public double RangeMin;
	public double RangeMax;
	public double RemappedMin;
	public double RemappedMax;
	public string ParameterName;
	public FBoneReference TargetBone;
	public EComponentType TargetComponent_DEPRECATED;
	public EDrivenDestinationMode DestinationMode;
	public EDrivenBoneModificationMode ModificationMode;
	public EComponentType SourceComponent;
	public bool bUseRange;
	public bool bAffectTargetTranslationX;
	public bool bAffectTargetTranslationY;
	public bool bAffectTargetTranslationZ;
	public bool bAffectTargetRotationX;
	public bool bAffectTargetRotationY;
	public bool bAffectTargetRotationZ;
	public bool bAffectTargetScaleX;
	public bool bAffectTargetScaleY;
	public bool bAffectTargetScaleZ;
}
