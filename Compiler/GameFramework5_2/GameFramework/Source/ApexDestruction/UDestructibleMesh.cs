#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleMesh.h")]
///<summary>Holds an APEX destructible asset as well as an associated USkeletalMesh.</summary>
public partial class UDestructibleMesh : USkeletalMesh {
// DestructibleMesh
	public FDestructibleParameters DefaultDestructibleParameters;
	public TArray<FFractureEffect> FractureEffects;
	public UDestructibleFractureSettings FractureSettings;
	public UStaticMesh SourceStaticMesh;
	public FDateTime SourceSMImportTimestamp;
	public TArray<UStaticMesh> FractureChunkMeshes;
}
