#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGStaticMeshSpawner.h")]
public partial struct FPCGStaticMeshSpawnerEntry {
// PCGStaticMeshSpawnerEntry
	public int Weight;
	public TSoftObjectPtr<UStaticMesh> Mesh;
	public bool bOverrideCollisionProfile;
	public FCollisionProfileName CollisionProfile;
}
