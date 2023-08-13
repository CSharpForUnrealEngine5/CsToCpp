namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGStaticMeshSpawner.h")]
public partial struct FPCGStaticMeshSpawnerEntry {
	public int Weight;
	public TSoftObjectPtr<UStaticMesh> Mesh;
	public bool bOverrideCollisionProfile;
	public FCollisionProfileName CollisionProfile;
}
