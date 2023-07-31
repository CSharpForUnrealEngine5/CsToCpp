#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Velocity/ParticleModuleVelocityCone.h")]
public partial class UParticleModuleVelocityCone : UParticleModuleVelocityBase {
	///<summary>The Min value represents the inner cone angle value and the Max value represents the outer cone angle value.</summary>
	public FRawDistributionFloat Angle;
	///<summary>The initial velocity of the particles.</summary>
	public FRawDistributionFloat Velocity;
	///<summary>The direction FVector of the cone.</summary>
	public FVector Direction;
}
