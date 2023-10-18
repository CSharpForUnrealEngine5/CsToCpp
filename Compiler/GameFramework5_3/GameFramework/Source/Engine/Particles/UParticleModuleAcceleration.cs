namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Acceleration/ParticleModuleAcceleration.h")]
public partial class UParticleModuleAcceleration : UParticleModuleAccelerationBase {
	public static UClass StaticClass() {return default;}
	///<summary>The initial acceleration of the particle.</summary>
	public FRawDistributionVector Acceleration;
	///<summary>If true, then apply the particle system components scale</summary>
	public bool bApplyOwnerScale;
}
