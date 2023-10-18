namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the runtime version of a bone driven controller, which maps part of the state from one bone to another (e.g., 2 * source.x -&gt; target.z)</summary>
[CppInclude("BoneControllers/AnimNode_BoneDrivenController.h")]
public partial struct FAnimNode_BoneDrivenController {
	public FBoneReference SourceBone;
	public UCurveFloat DrivingCurve;
	public float Multiplier;
	public double RangeMin;
	public double RangeMax;
	public double RemappedMin;
	public double RemappedMax;
	public FName ParameterName;
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
