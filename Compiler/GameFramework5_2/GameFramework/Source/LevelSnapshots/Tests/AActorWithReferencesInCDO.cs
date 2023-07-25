#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Types/ActorWithReferencesInCDO.h")]
public partial class AActorWithReferencesInCDO : AActor {
// ActorWithReferencesInCDO
	public TArray<FExternalReferenceDummy> Array;
	public TSet<FExternalReferenceDummy> Set;
	public TMap<int,FExternalReferenceDummy> IntKeyMap;
	public TMap<FExternalReferenceDummy,int> IntValueMap;
	public FExternalReferenceDummy Struct;
	public UStaticMesh CubeMesh;
	public UStaticMesh CylinderMesh;
}
