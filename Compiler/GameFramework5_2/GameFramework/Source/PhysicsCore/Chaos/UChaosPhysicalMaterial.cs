#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Physical materials are used to define the response of a physical object when</summary>
[CppInclude("Chaos/ChaosPhysicalMaterial.h")]
public partial class UChaosPhysicalMaterial : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Friction value of a surface in motion, controls how easily things can slide on this surface (0 is frictionless, higher values increase the amount of friction)</summary>
	public float Friction;
	///<summary>Friction value of surface at rest, controls how easily things can slide on this surface (0 is frictionless, higher values increase the amount of friction)</summary>
	public float StaticFriction;
	///<summary>Restitution or &#39;bounciness&#39; of this surface, between 0 (no bounce) and 1 (outgoing velocity is same as incoming).</summary>
	public float Restitution;
	///<summary>Uniform linear ether drag, the resistance a body experiences to its translation.</summary>
	public float LinearEtherDrag;
	///<summary>Uniform angular ether drag, the resistance a body experiences to its rotation.</summary>
	public float AngularEtherDrag;
	///<summary>How much to scale the damage threshold by on any destructible we are applied to</summary>
	public float SleepingLinearVelocityThreshold;
	///<summary>How much to scale the damage threshold by on any destructible we are applied to</summary>
	public float SleepingAngularVelocityThreshold;
}
