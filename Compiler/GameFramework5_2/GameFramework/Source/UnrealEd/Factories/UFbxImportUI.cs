#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxImportUI.h")]
public partial class UFbxImportUI : UObject {
	///<summary>Whether or not the imported file is in OBJ format</summary>
	public bool bIsObjImport;
	///<summary>The original detected type of this import</summary>
	public EFBXImportType OriginalImportType;
	///<summary>Type of asset to import from the FBX file</summary>
	public EFBXImportType MeshTypeToImport;
	///<summary>Use the string in &quot;Name&quot; field as full name of mesh. The option only works when the scene contains one mesh.</summary>
	public bool bOverrideFullName;
	///<summary>Whether to import the incoming FBX as a skeletal object</summary>
	public bool bImportAsSkeletal;
	///<summary>Whether to import the mesh. Allows animation only import when importing a skeletal mesh.</summary>
	public bool bImportMesh;
	///<summary>Skeleton to use for imported asset. When importing a mesh, leaving this as &quot;None&quot; will create a new skeleton. When importing an animation this MUST be specified to import the asset.</summary>
	public USkeleton Skeleton;
	///<summary>If checked, create new PhysicsAsset if it doesn&#39;t have it</summary>
	public bool bCreatePhysicsAsset;
	///<summary>If this is set, use this PhysicsAsset. It is possible bCreatePhysicsAsset == false, and PhysicsAsset == NULL. It is possible they do not like to create anything.</summary>
	public UPhysicsAsset PhysicsAsset;
	///<summary>If checked, the editor will automatically compute screen size values for the static mesh&#39;s LODs. If unchecked, the user can enter custom screen size values for each LOD.</summary>
	public bool bAutoComputeLodDistances;
	///<summary>Set a screen size value for LOD 0</summary>
	public float LodDistance0;
	///<summary>Set a screen size value for LOD 1</summary>
	public float LodDistance1;
	///<summary>Set a screen size value for LOD 2</summary>
	public float LodDistance2;
	///<summary>Set a screen size value for LOD 3</summary>
	public float LodDistance3;
	///<summary>Set a screen size value for LOD 4</summary>
	public float LodDistance4;
	///<summary>Set a screen size value for LOD 5</summary>
	public float LodDistance5;
	///<summary>Set a screen size value for LOD 6</summary>
	public float LodDistance6;
	///<summary>Set a screen size value for LOD 7</summary>
	public float LodDistance7;
	///<summary>Set the minimum LOD used for rendering. Setting the value to 0 will use the default value of LOD0.</summary>
	public int MinimumLodNumber;
	///<summary>Set the number of LODs for the editor to import. Setting the value to 0 imports the number of LODs found in the file (up to the maximum).</summary>
	public int LodNumber;
	///<summary>True to import animations from the FBX File</summary>
	public bool bImportAnimations;
	///<summary>Override for the name of the animation to import. By default, it will be the name of FBX *</summary>
	public string OverrideAnimationName;
	///<summary>Enables importing of &#39;rigid skeletalmesh&#39; (unskinned, hierarchy-based animation) from this FBX file, no longer shown, used behind the scenes</summary>
	public bool bImportRigidMesh;
	///<summary>If no existing materials are found, whether to automatically create Unreal materials for materials found in the FBX scene</summary>
	public bool bImportMaterials;
	///<summary>Whether or not we should import textures. This option is disabled when we are importing materials because textures are always imported in that case.</summary>
	public bool bImportTextures;
	///<summary>If true, the imported material sections will automatically be reset to the imported data in case of a reimport conflict.</summary>
	public bool bResetToFbxOnMaterialConflict;
	///<summary>Import data used when importing static meshes</summary>
	public UFbxStaticMeshImportData StaticMeshImportData;
	///<summary>Import data used when importing skeletal meshes</summary>
	public UFbxSkeletalMeshImportData SkeletalMeshImportData;
	///<summary>Import data used when importing animations</summary>
	public UFbxAnimSequenceImportData AnimSequenceImportData;
	///<summary>Import data used when importing textures</summary>
	public UFbxTextureImportData TextureImportData;
	///<summary>If true the automated import path should detect the import type.  If false the import type was specified by the user</summary>
	public bool bAutomatedImportShouldDetectType;
	///<summary>ResetToDefault</summary>
	public  void ResetToDefault() {}
	///<summary>The fbx file version</summary>
	public string FileVersion;
	///<summary>The file creator information</summary>
	public string FileCreator;
	///<summary>The file vendor information, software name and version that was use to create the file</summary>
	public string FileCreatorApplication;
	///<summary>The file units</summary>
	public string FileUnits;
	///<summary>The file axis direction, up vector and hand</summary>
	public string FileAxisDirection;
	///<summary>The fbx animation frame rate</summary>
	public string FileSampleRate;
	///<summary>The fbx animation start frame</summary>
	public string AnimStartFrame;
	///<summary>The fbx animation end frame</summary>
	public string AnimEndFrame;
}
