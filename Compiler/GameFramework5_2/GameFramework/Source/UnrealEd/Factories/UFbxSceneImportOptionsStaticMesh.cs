#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportOptionsStaticMesh.h")]
public partial class UFbxSceneImportOptionsStaticMesh : UObject {
// FbxSceneImportOptionsStaticMesh
	public string StaticMeshLODGroup;
	public bool bAutoGenerateCollision;
	public EFbxSceneVertexColorImportOption VertexColorImportOption;
	public FColor VertexOverrideColor;
	public bool bRemoveDegenerates;
	public bool bBuildReversedIndexBuffer;
	public bool bGenerateLightmapUVs;
	public bool bOneConvexHullPerUCX;
	public EFBXSceneNormalImportMethod NormalImportMethod;
	public EFBXSceneNormalGenerationMethod NormalGenerationMethod;
}
