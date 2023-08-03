#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fbx_AddToBlueprint UMETA(DisplayName = &quot;Add to an existing Blueprint asset&quot;),</summary>
[CppInclude("Factories/FbxSceneImportOptions.h")]
public partial class UFbxSceneImportOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If checked, a folder&#39;s hierarchy will be created under the import asset path. All the created folders will match the actor hierarchy. In case there is more than one actor that links to an asset, the shared asset will be placed at the first actor&#39;s place.</summary>
	public bool bCreateContentFolderHierarchy;
	///<summary>If checked, the mobility of all actors or components will be dynamic. If unchecked, they will be static.</summary>
	public bool bImportAsDynamic;
	///<summary>Choose if you want to generate the scene hierarchy with normal level actors, one actor with multiple components, or one blueprint asset with multiple components.</summary>
	public EFBXSceneOptionsCreateHierarchyType HierarchyType;
	///<summary>Whether to force the front axis to be align with X instead of -Y.</summary>
	public bool bForceFrontXAxis;
	///<summary>ImportTranslation</summary>
	public FVector ImportTranslation;
	///<summary>ImportRotation</summary>
	public FRotator ImportRotation;
	///<summary>ImportUniformScale</summary>
	public float ImportUniformScale;
	///<summary>If this option is true the node absolute transform (transform, offset and pivot) will be apply to the mesh vertices.</summary>
	public bool bTransformVertexToAbsolute;
	///<summary>- Experimental - If this option is true the inverse node pivot will be apply to the mesh vertices. The pivot from the DCC will then be the origin of the mesh. This option only work with static meshes.</summary>
	public bool bBakePivotInVertex;
	///<summary>If enabled, creates LOD models for Unreal static meshes from LODs in the import file; If not enabled, only the base static mesh from the LOD group is imported.</summary>
	public bool bImportStaticMeshLODs;
	///<summary>If enabled, creates LOD models for Unreal skeletal meshes from LODs in the import file; If not enabled, only the base skeletal mesh from the LOD group is imported.</summary>
	public bool bImportSkeletalMeshLODs;
	///<summary>If enabled, this option will cause normal map Y (Green) values to be inverted when importing textures</summary>
	public bool bInvertNormalMaps;
}
