#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxAnimSequenceImportData.h")]
///<summary>Import data and options used when importing any mesh from FBX</summary>
public partial class UFbxAnimSequenceImportData : UFbxAssetImportData {
// FbxAnimSequenceImportData
	public bool bImportMeshesInBoneHierarchy;
	public byte AnimationLength;
	public int StartFrame_DEPRECATED;
	public int EndFrame_DEPRECATED;
	public FInt32Interval FrameImportRange;
	public bool bUseDefaultSampleRate;
	public int CustomSampleRate;
	public bool bSnapToClosestFrameBoundary;
	public string SourceAnimationName;
	public bool bImportCustomAttribute;
	public bool bDeleteExistingCustomAttributeCurves;
	public bool bDeleteExistingNonCurveCustomAttributes;
	public bool bImportBoneTracks;
	public bool bSetMaterialDriveParameterOnCustomAttribute;
	public TArray<string> MaterialCurveSuffixes;
	public bool bRemoveRedundantKeys;
	public bool bDeleteExistingMorphTargetCurves;
	public bool bDoNotImportCurveWithZero;
	public bool bPreserveLocalTransform;
}
