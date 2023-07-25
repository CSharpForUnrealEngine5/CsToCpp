#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationBoneSocket.h")]
public partial class UParticleModuleLocationBoneSocket : UParticleModuleLocationBase {
// ParticleModuleLocationBoneSocket
	public byte SourceType;
	public FVector UniversalOffset;
	public TArray<FLocationBoneSocketInfo> SourceLocations;
	public byte SelectionMethod;
	public bool bUpdatePositionEachFrame;
	public bool bOrientMeshEmitters;
	public bool bInheritBoneVelocity;
	public float InheritVelocityScale;
	public string SkelMeshActorParamName;
	public int NumPreSelectedIndices;
	public USkeletalMesh EditorSkelMesh;
}
