namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simplified UStruct version of FParticleDynamics.</summary>
[CppInclude("DataWrappers/ChaosVDParticleDataWrapper.h")]
public partial struct FChaosVDParticleDynamics {
	public FVector MAcceleration;
	public FVector MAngularAcceleration;
	public FVector MLinearImpulseVelocity;
	public FVector MAngularImpulseVelocity;
}
