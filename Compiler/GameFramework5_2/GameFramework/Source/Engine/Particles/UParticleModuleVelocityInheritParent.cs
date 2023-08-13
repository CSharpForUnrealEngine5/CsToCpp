namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Velocity/ParticleModuleVelocityInheritParent.h")]
public partial class UParticleModuleVelocityInheritParent : UParticleModuleVelocityBase {
	public static UClass StaticClass() {return default;}
	///<summary>The scale to apply to the parent velocity prior to adding it to the particle velocity during spawn.</summary>
	public FRawDistributionVector Scale;
}
