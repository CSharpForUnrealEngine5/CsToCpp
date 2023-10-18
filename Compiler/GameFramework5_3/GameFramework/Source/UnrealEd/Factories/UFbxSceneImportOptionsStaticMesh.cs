namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxSceneImportOptionsStaticMesh.h")]
public partial class UFbxSceneImportOptionsStaticMesh : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>For static meshes, enabling this option will combine all meshes in the FBX into a single monolithic mesh in Unreal</summary>
	public FName StaticMeshLODGroup;
	///<summary>If checked, collision will automatically be generated (ignored if custom collision is imported or used).</summary>
	public bool bAutoGenerateCollision;
	///<summary>Specify how vertex colors should be imported</summary>
	public EFbxSceneVertexColorImportOption VertexColorImportOption;
	///<summary>Specify override color in the case that VertexColorImportOption is set to Override</summary>
	public FColor VertexOverrideColor;
	///<summary>Disabling this option will keep degenerate triangles found.  In general you should leave this option on.</summary>
	public bool bRemoveDegenerates;
	///<summary>bBuildReversedIndexBuffer</summary>
	public bool bBuildReversedIndexBuffer;
	///<summary>bGenerateLightmapUVs</summary>
	public bool bGenerateLightmapUVs;
	///<summary>If checked, one convex hull per UCX_ prefixed collision mesh will be generated instead of decomposing into multiple hulls</summary>
	public bool bOneConvexHullPerUCX;
	///<summary>Enabling this option will read the tangents(tangent,binormal,normal) from FBX file instead of generating them automatically.</summary>
	public EFBXSceneNormalImportMethod NormalImportMethod;
	///<summary>Use the MikkTSpace tangent space generator for generating normals and tangents on the mesh</summary>
	public EFBXSceneNormalGenerationMethod NormalGenerationMethod;
}
