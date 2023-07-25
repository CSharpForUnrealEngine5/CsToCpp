#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericAnimationPipeline.h")]
public partial class UInterchangeGenericAnimationPipeline : UInterchangePipelineBase {
// InterchangeGenericAnimationPipeline
	public TWeakObjectPtr<UInterchangeGenericCommonSkeletalMeshesAndAnimationsProperties> CommonSkeletalMeshesAndAnimationsProperties;
	public bool bImportAnimations;
	public bool bImportBoneTracks;
	public EInterchangeAnimationRange AnimationRange;
	public FInt32Interval FrameImportRange;
	public bool bUse30HzToBakeBoneAnimation;
	public int CustomBoneAnimationSampleRate;
	public bool bSnapToClosestFrameBoundary;
	public bool bImportCustomAttribute;
	public bool bSetMaterialDriveParameterOnCustomAttribute;
	public TArray<string> MaterialCurveSuffixes;
	public bool bRemoveCurveRedundantKeys;
	public bool bDoNotImportCurveWithZero;
	public bool bDeleteExistingNonCurveCustomAttributes;
	public bool bDeleteExistingCustomAttributeCurves;
	public bool bDeleteExistingMorphTargetCurves;
	public string SourceAnimationName;
}
