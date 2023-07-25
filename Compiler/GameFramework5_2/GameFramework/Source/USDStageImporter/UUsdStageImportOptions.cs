#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageImportOptions.h")]
public partial class UUsdStageImportOptions : UObject {
// UsdStageImportOptions
	public bool bImportActors;
	public bool bImportGeometry;
	public bool bImportSkeletalAnimations;
	public bool bImportLevelSequences;
	public bool bImportMaterials;
	public bool bImportOnlyUsedMaterials;
	public TArray<string> PrimsToImport;
	public int PurposesToImport;
	public int NaniteTriangleThreshold;
	public string RenderContextToImport;
	public string MaterialPurpose;
	public EUsdRootMotionHandling RootMotionHandling;
	public bool bOverrideStageOptions;
	public FUsdStageOptions StageOptions;
	public bool bImportAtSpecificTimeCode;
	public float ImportTimeCode;
	public TArray<FHairGroupsInterpolation> GroomInterpolationSettings;
	public EReplaceActorPolicy ExistingActorPolicy;
	public EReplaceAssetPolicy ExistingAssetPolicy;
	public bool bPrimPathFolderStructure;
	public int KindsToCollapse;
	public bool bMergeIdenticalMaterialSlots;
	public bool bCollapseTopLevelPointInstancers;
	public bool bInterpretLODs;
}
