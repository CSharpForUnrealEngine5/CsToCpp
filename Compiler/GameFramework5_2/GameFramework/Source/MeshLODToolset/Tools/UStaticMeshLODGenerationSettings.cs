#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/LODGenerationSettingsAsset.h")]
///<summary>UStaticMeshLODGenerationSettings is intended to be a stored version of the settings used</summary>
public partial class UStaticMeshLODGenerationSettings : UObject {
// StaticMeshLODGenerationSettings
	public FGenerateStaticMeshLODProcess_PreprocessSettings Preprocessing;
	public FGenerateStaticMeshLODProcessSettings MeshGeneration;
	public FGenerateStaticMeshLODProcess_SimplifySettings Simplification;
	public FGenerateStaticMeshLODProcess_NormalsSettings Normals;
	public FGenerateStaticMeshLODProcess_TextureSettings TextureBaking;
	public FGenerateStaticMeshLODProcess_UVSettings UVGeneration;
	public FGenerateStaticMeshLODProcess_CollisionSettings SimpleCollision;
}
