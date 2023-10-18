namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Velocity/ParticleModuleVelocityCone.h")]
public partial class UParticleModuleVelocityCone : UParticleModuleVelocityBase {
	public static UClass StaticClass() {return default;}
	///<summary>The Min value represents the inner cone angle value and the Max value represents the outer cone angle value.</summary>
	public FRawDistributionFloat Angle;
	///<summary>The initial velocity of the particles.</summary>
	public FRawDistributionFloat Velocity;
	///<summary>The direction FVector of the cone.</summary>
	public FVector Direction;
}
