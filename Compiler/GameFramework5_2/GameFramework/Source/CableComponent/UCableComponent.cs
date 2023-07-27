#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CableComponent.h")]
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
public partial class UCableComponent : UMeshComponent {
// CableComponent
	public bool bAttachStart;
	public bool bAttachEnd;
	public FComponentReference AttachEndTo;
	public string AttachEndToSocketName;
	public FVector EndLocation;
	public  void SetAttachEndToComponent(USceneComponent Component,string SocketName/*=NAME_None*/) {}
	public  void SetAttachEndTo(AActor Actor,string ComponentProperty,string SocketName/*=NAME_None*/) {}
	public  AActor GetAttachedActor() { return default; }
	public  USceneComponent GetAttachedComponent() { return default; }
	public  void GetCableParticleLocations(TArray<FVector> Locations) {}
	public float CableLength;
	public int NumSegments;
	public float SubstepTime;
	public int SolverIterations;
	public bool bEnableStiffness;
	public bool bUseSubstepping;
	public bool bSkipCableUpdateWhenNotVisible;
	public bool bSkipCableUpdateWhenNotOwnerRecentlyRendered;
	public bool bEnableCollision;
	public float CollisionFriction;
	public FVector CableForce;
	public float CableGravityScale;
	public float CableWidth;
	public int NumSides;
	public float TileMaterial;
}
