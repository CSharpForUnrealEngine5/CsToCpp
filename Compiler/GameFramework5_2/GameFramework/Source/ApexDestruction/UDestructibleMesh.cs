#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds an APEX destructible asset as well as an associated USkeletalMesh.</summary>
[CppInclude("DestructibleMesh.h")]
public partial class UDestructibleMesh : USkeletalMesh {
	public static UClass StaticClass() {return default;}
	///<summary>Parameters controlling the destruction behavior.</summary>
	public FDestructibleParameters DefaultDestructibleParameters;
	///<summary>Fracture effects for each fracture level, unless overridden in the component.</summary>
	public TArray<FFractureEffect> FractureEffects;
	///<summary>Information used to author an NxDestructibleAsset</summary>
	public UDestructibleFractureSettings FractureSettings;
	///<summary>Static mesh this destructible mesh is created from. Is nullptr if not created from a static mesh</summary>
	public UStaticMesh SourceStaticMesh;
	///<summary>Timestamp of the source static meshes last import at the time this destruction mesh has been generated.</summary>
	public FDateTime SourceSMImportTimestamp;
	///<summary>Array of static meshes to build the fracture chunks from</summary>
	public TArray<UStaticMesh> FractureChunkMeshes;
}
