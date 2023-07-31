#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Location/ParticleModuleLocationBoneSocket.h")]
public partial class UParticleModuleLocationBoneSocket : UParticleModuleLocationBase {
	///<summary>Whether the module uses Bones or Sockets for locations.</summary>
	public ELocationBoneSocketSource SourceType;
	///<summary>An offset to apply to each bone/socket</summary>
	public FVector UniversalOffset;
	///<summary>The name(s) of the bone/socket(s) to position at. If this is empty, the module will attempt to spawn from all bones or sockets.</summary>
	public TArray<FLocationBoneSocketInfo> SourceLocations;
	///<summary>The method by which to select the bone/socket to spawn at.</summary>
	public ELocationBoneSocketSelectionMethod SelectionMethod;
	///<summary>If true, update the particle locations each frame with that of the bone/socket</summary>
	public bool bUpdatePositionEachFrame;
	///<summary>If true, rotate mesh emitter meshes to orient w/ the socket. Currently does nothing.</summary>
	public bool bOrientMeshEmitters;
	///<summary>If true, particles inherit the associated bone velocity when spawned</summary>
	public bool bInheritBoneVelocity;
	///<summary>A scale on how much of the bone&#39;s velocity a particle will inherit.</summary>
	public float InheritVelocityScale;
	///<summary>The parameter name of the skeletal mesh actor that supplies the SkelMeshComponent for in-game.</summary>
	public string SkelMeshActorParamName;
	///<summary>When we have no source locations and we need to track bone velocities due to bInheritBoneVelocity, we pre select a set of bones to use each frame. This property determines how big the list is.</summary>
	public int NumPreSelectedIndices;
	///<summary>The name of the skeletal mesh to use in the editor</summary>
	public USkeletalMesh EditorSkelMesh;
}
