namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
[CppInclude("CableComponent.h")]
public partial class UCableComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Should we fix the start to something, or leave it free.</summary>
	public bool bAttachStart;
	///<summary>Should we fix the end to something (using AttachEndTo and EndLocation), or leave it free.</summary>
	public bool bAttachEnd;
	///<summary>Actor or Component that the defines the end position of the cable</summary>
	public FComponentReference AttachEndTo;
	///<summary>Socket name on the AttachEndTo component to attach to</summary>
	public FName AttachEndToSocketName;
	///<summary>End location of cable, relative to AttachEndTo (or AttachEndToSocketName) if specified, otherwise relative to cable component.</summary>
	public FVector EndLocation;
	///<summary>Attaches the end of the cable to a specific Component *</summary>
	public void SetAttachEndToComponent(USceneComponent Component,FName SocketName/*=NAME_None*/) {}
	///<summary>Attaches the end of the cable to a specific Component within an Actor *</summary>
	public void SetAttachEndTo(AActor Actor,FName ComponentProperty,FName SocketName/*=NAME_None*/) {}
	///<summary>Gets the Actor that the cable is attached to *</summary>
	public AActor GetAttachedActor() { return default; }
	///<summary>Gets the specific USceneComponent that the cable is attached to *</summary>
	public USceneComponent GetAttachedComponent() { return default; }
	///<summary>Get array of locations of particles (in world space) making up the cable simulation.</summary>
	public void GetCableParticleLocations(TArray<FVector> Locations) {}
	///<summary>Rest length of the cable</summary>
	public float CableLength;
	///<summary>How many segments the cable has</summary>
	public int NumSegments;
	///<summary>Controls the simulation substep time for the cable</summary>
	public float SubstepTime;
	///<summary>The number of solver iterations controls how &#39;stiff&#39; the cable is</summary>
	public int SolverIterations;
	///<summary>Add stiffness constraints to cable.</summary>
	public bool bEnableStiffness;
	///<summary>When false, will still wait for SubstepTime to elapse before updating, but will only run the cable simulation once using all of accumulated simulation time</summary>
	public bool bUseSubstepping;
	///<summary>bSkipCableUpdateWhenNotVisible</summary>
	public bool bSkipCableUpdateWhenNotVisible;
	///<summary>bSkipCableUpdateWhenNotOwnerRecentlyRendered</summary>
	public bool bSkipCableUpdateWhenNotOwnerRecentlyRendered;
	///<summary>EXPERIMENTAL. Perform sweeps for each cable particle, each substep, to avoid collisions with the world.</summary>
	public bool bEnableCollision;
	///<summary>If collision is enabled, control how much sliding friction is applied when cable is in contact.</summary>
	public float CollisionFriction;
	///<summary>Force vector (world space) applied to all particles in cable.</summary>
	public FVector CableForce;
	///<summary>Scaling applied to world gravity affecting this cable.</summary>
	public float CableGravityScale;
	///<summary>How wide the cable geometry is</summary>
	public float CableWidth;
	///<summary>Number of sides of the cable geometry</summary>
	public int NumSides;
	///<summary>How many times to repeat the material along the length of the cable</summary>
	public float TileMaterial;
}
