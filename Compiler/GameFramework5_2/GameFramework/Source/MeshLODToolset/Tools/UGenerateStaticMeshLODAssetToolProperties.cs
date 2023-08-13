namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties</summary>
[CppInclude("Tools/GenerateStaticMeshLODAssetTool.h")]
public partial class UGenerateStaticMeshLODAssetToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Preprocessing</summary>
	public FGenerateStaticMeshLODProcess_PreprocessSettings Preprocessing;
	///<summary>MeshGeneration</summary>
	public FGenerateStaticMeshLODProcessSettings MeshGeneration;
	///<summary>Simplification</summary>
	public FGenerateStaticMeshLODProcess_SimplifySettings Simplification;
	///<summary>Normals</summary>
	public FGenerateStaticMeshLODProcess_NormalsSettings Normals;
	///<summary>TextureBaking</summary>
	public FGenerateStaticMeshLODProcess_TextureSettings TextureBaking;
	///<summary>UVGeneration</summary>
	public FGenerateStaticMeshLODProcess_UVSettings UVGeneration;
	///<summary>SimpleCollision</summary>
	public FGenerateStaticMeshLODProcess_CollisionSettings SimpleCollision;
	///<summary>Group layer to use for partitioning the mesh for simple collision generation</summary>
	public string CollisionGroupLayerName;
	///<summary>this function is called provide set of available group layers</summary>
	public TArray<string> GetGroupLayersFunc() { return default; }
	///<summary>internal list used to implement above</summary>
	public TArray<string> GroupLayersList;
}
