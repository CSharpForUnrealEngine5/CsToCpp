namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageImportOptions.h")]
public partial class UUsdStageImportOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bImportActors</summary>
	public bool bImportActors;
	///<summary>bImportGeometry</summary>
	public bool bImportGeometry;
	///<summary>Whether to try importing UAnimSequence skeletal animation assets for each encountered UsdSkelAnimQuery</summary>
	public bool bImportSkeletalAnimations;
	///<summary>bImportLevelSequences</summary>
	public bool bImportLevelSequences;
	///<summary>bImportMaterials</summary>
	public bool bImportMaterials;
	///<summary>If this is checked, only materials actively used by the stage and import settings will be parsed.</summary>
	public bool bImportOnlyUsedMaterials;
	///<summary>List of paths of prims to import (e.g. [&quot;/Root/MyBox&quot;, &quot;/Root/OtherPrim&quot;]).</summary>
	public TArray<string> PrimsToImport;
	///<summary>Only import prims with these specific purposes from the USD file</summary>
	public int PurposesToImport;
	///<summary>Try enabling Nanite for static meshes that are generated with at least this many triangles</summary>
	public int NaniteTriangleThreshold;
	///<summary>Specifies which set of shaders to use when parsing USD materials, in addition to the universal render context.</summary>
	public FName RenderContextToImport;
	///<summary>Specifies which material purpose to use when parsing USD material bindings, in addition to the &quot;allPurpose&quot; fallback</summary>
	public FName MaterialPurpose;
	///<summary>Describes what to add to the root bone animation within generated AnimSequences, if anything</summary>
	public EUsdRootMotionHandling RootMotionHandling;
	///<summary>Whether to use the specified StageOptions instead of the stage&#39;s own settings</summary>
	public bool bOverrideStageOptions;
	///<summary>Custom StageOptions to use for the stage</summary>
	public FUsdStageOptions StageOptions;
	///<summary>When true the stage will be evaluated at ImportTimeCode for the import.</summary>
	public bool bImportAtSpecificTimeCode;
	///<summary>TimeCode to evaluate the stage for import, in case bImportAtSpecificTimeCode is enabled</summary>
	public float ImportTimeCode;
	///<summary>Groom group interpolation settings</summary>
	public TArray<FHairGroupsInterpolation> GroomInterpolationSettings;
	///<summary>What should happen when imported actors and components try to overwrite existing actors and components</summary>
	public EReplaceActorPolicy ExistingActorPolicy;
	///<summary>What should happen when imported assets try to overwrite existing assets</summary>
	public EReplaceAssetPolicy ExistingAssetPolicy;
	///<summary>When enabled, assets will be imported into a content folder structure according to their prim path. When disabled,</summary>
	public bool bPrimPathFolderStructure;
	///<summary>Whether to try to combine individual assets and components of the same type on a kind-per-kind basis,</summary>
	public int KindsToCollapse;
	///<summary>If enabled, when multiple mesh prims are collapsed into a single static mesh, identical material slots are merged into one slot.</summary>
	public bool bMergeIdenticalMaterialSlots;
	///<summary>bCollapseTopLevelPointInstancers</summary>
	public bool bCollapseTopLevelPointInstancers;
	///<summary>When true, if a prim has a &quot;LOD&quot; variant set with variants named &quot;LOD0&quot;, &quot;LOD1&quot;, etc. where each contains a UsdGeomMesh, the importer will attempt to parse the meshes as separate LODs of a single UStaticMesh. When false, only the selected variant will be parsed as LOD0 of the UStaticMesh.</summary>
	public bool bInterpretLODs;
}
