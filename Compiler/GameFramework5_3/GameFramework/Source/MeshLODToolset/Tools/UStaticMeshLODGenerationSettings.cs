namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStaticMeshLODGenerationSettings is intended to be a stored version of the settings used</summary>
[CppInclude("Tools/LODGenerationSettingsAsset.h")]
public partial class UStaticMeshLODGenerationSettings : UObject {
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
}
