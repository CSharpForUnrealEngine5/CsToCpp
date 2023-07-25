#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportOptions.h")]
///<summary>Fbx_AddToBlueprint UMETA(DisplayName = "Add to an existing Blueprint asset"),</summary>
public partial class UFbxSceneImportOptions : UObject {
// FbxSceneImportOptions
	public bool bCreateContentFolderHierarchy;
	public bool bImportAsDynamic;
	public EFBXSceneOptionsCreateHierarchyType HierarchyType;
	public bool bForceFrontXAxis;
	public FVector ImportTranslation;
	public FRotator ImportRotation;
	public float ImportUniformScale;
	public bool bTransformVertexToAbsolute;
	public bool bBakePivotInVertex;
	public bool bImportStaticMeshLODs;
	public bool bImportSkeletalMeshLODs;
	public bool bInvertNormalMaps;
}
