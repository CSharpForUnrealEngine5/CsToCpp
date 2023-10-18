namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simplified UStruct version of FParticleMassProps.</summary>
[CppInclude("DataWrappers/ChaosVDParticleDataWrapper.h")]
public partial struct FChaosVDParticleMassProps {
	public FVector MCenterOfMass;
	public FQuat MRotationOfMass;
	public FVector MI;
	public FVector MInvI;
	public double MM;
	public double MInvM;
}
