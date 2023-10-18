namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import data and options used when importing any mesh from FBX</summary>
[CppInclude("Factories/FbxAnimSequenceImportData.h")]
public partial class UFbxAnimSequenceImportData : UFbxAssetImportData {
	public static UClass StaticClass() {return default;}
	///<summary>If checked, meshes nested in bone hierarchies will be imported instead of being converted to bones.</summary>
	public bool bImportMeshesInBoneHierarchy;
	///<summary>Which animation range to import. The one defined at Exported, at Animated time or define a range manually</summary>
	public EFBXAnimationLengthImportType AnimationLength;
	///<summary>Start frame when Set Range is used in Animation Length</summary>
	public int StartFrame_DEPRECATED;
	///<summary>End frame when Set Range is used in Animation Length</summary>
	public int EndFrame_DEPRECATED;
	///<summary>Frame range used when Set Range is used in Animation Length</summary>
	public FInt32Interval FrameImportRange;
	///<summary>If enabled, samples all animation curves to 30 FPS</summary>
	public bool bUseDefaultSampleRate;
	///<summary>Sample fbx animation data at the specified sample rate, 0 find automaticaly the best sample rate</summary>
	public int CustomSampleRate;
	///<summary>If enabled, snaps the animation to the closest frame boundary using the import sampling rate</summary>
	public bool bSnapToClosestFrameBoundary;
	///<summary>Name of source animation that was imported, used to reimport correct animation from the FBX file</summary>
	public string SourceAnimationName;
	///<summary>If true, import node attributes as either Animation Curves or Animation Attributes</summary>
	public bool bImportCustomAttribute;
	///<summary>If true, all previous node attributes imported as Animation Curves will be deleted when doing a re-import.</summary>
	public bool bDeleteExistingCustomAttributeCurves;
	///<summary>If true, all previous node attributes imported as Animation Attributes will be deleted when doing a re-import.</summary>
	public bool bDeleteExistingNonCurveCustomAttributes;
	///<summary>Import bone transform tracks. If false, this will discard any bone transform tracks. (useful for curves only animations)</summary>
	public bool bImportBoneTracks;
	///<summary>Set Material Curve Type for all custom attributes that exists</summary>
	public bool bSetMaterialDriveParameterOnCustomAttribute;
	///<summary>Whether to automatically add curve metadata to an animation&#39;s skeleton. If this is disabled, curve metadata will be added to skeletal meshes for morph targets, but no metadata entry will be created for general curves.</summary>
	public bool bAddCurveMetadataToSkeleton;
	///<summary>Set Material Curve Type for the custom attribute with the following suffixes. This doesn&#39;t matter if Set Material Curve Type is true</summary>
	public TArray<string> MaterialCurveSuffixes;
	///<summary>When importing custom attribute as curve, remove redundant keys</summary>
	public bool bRemoveRedundantKeys;
	///<summary>If enabled, this will delete this type of asset from the FBX</summary>
	public bool bDeleteExistingMorphTargetCurves;
	///<summary>When importing custom attribute or morphtarget as curve, do not import if it doesn&#39;t have any value other than zero. This is to avoid adding extra curves to evaluate</summary>
	public bool bDoNotImportCurveWithZero;
	///<summary>If enabled, this will import a curve within the animation</summary>
	public bool bPreserveLocalTransform;
}
