#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStaticMeshLODGenerationSettings is intended to be a stored version of the settings used</summary>
[CppInclude("Tools/LODGenerationSettingsAsset.h")]
public partial class UStaticMeshLODGenerationSettings : UObject {
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
