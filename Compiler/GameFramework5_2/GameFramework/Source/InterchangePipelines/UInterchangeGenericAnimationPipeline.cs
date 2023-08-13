namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericAnimationPipeline.h")]
public partial class UInterchangeGenericAnimationPipeline : UInterchangePipelineBase {
	public static UClass StaticClass() {return default;}
	///<summary>Common SkeletalMeshes And Animations Properties Settings Pointer</summary>
	public TWeakObjectPtr<UInterchangeGenericCommonSkeletalMeshesAndAnimationsProperties> CommonSkeletalMeshesAndAnimationsProperties;
	///<summary>If enable, import all animation assets find in the sources.</summary>
	public bool bImportAnimations;
	///<summary>Import bone transform tracks. If false, this will discard any bone transform tracks.</summary>
	public bool bImportBoneTracks;
	///<summary>Which animation range to import. The one defined at Exported, at Animated time or define a range manually</summary>
	public EInterchangeAnimationRange AnimationRange;
	///<summary>Frame range used when Set Range is used in Animation Length</summary>
	public FInt32Interval FrameImportRange;
	///<summary>If enabled, samples all animation curves to 30 FPS</summary>
	public bool bUse30HzToBakeBoneAnimation;
	///<summary>Sample fbx animation data at the specified sample rate, 0 find automaticaly the best sample rate</summary>
	public int CustomBoneAnimationSampleRate;
	///<summary>If enabled, snaps the animation to the closest frame boundary using the import sampling rate</summary>
	public bool bSnapToClosestFrameBoundary;
	///<summary>If true, import node attributes as either Animation Curves or Animation Attributes</summary>
	public bool bImportCustomAttribute;
	///<summary>Set Material Curve Type for all custom attributes that exists</summary>
	public bool bSetMaterialDriveParameterOnCustomAttribute;
	///<summary>Set Material Curve Type for the custom attribute with the following suffixes. This doesn&#39;t matter if Set Material Curve Type is true</summary>
	public TArray<string> MaterialCurveSuffixes;
	///<summary>When importing custom attribute as curve, remove redundant keys</summary>
	public bool bRemoveCurveRedundantKeys;
	///<summary>When importing custom attribute or morphtarget as curve, do not import if it doesn&#39;t have any value other than zero. This is to avoid adding extra curves to evaluate</summary>
	public bool bDoNotImportCurveWithZero;
	///<summary>If true, all previous node attributes imported as Animation Attributes will be deleted when doing a re-import.</summary>
	public bool bDeleteExistingNonCurveCustomAttributes;
	///<summary>If true, all previous node attributes imported as Animation Curves will be deleted when doing a re-import.</summary>
	public bool bDeleteExistingCustomAttributeCurves;
	///<summary>If true, all previous morph target curves will be deleted when doing a re-import</summary>
	public bool bDeleteExistingMorphTargetCurves;
	///<summary>Name of source animation that was imported, used to reimport correct animation from the translated source</summary>
	public string SourceAnimationName;
}
