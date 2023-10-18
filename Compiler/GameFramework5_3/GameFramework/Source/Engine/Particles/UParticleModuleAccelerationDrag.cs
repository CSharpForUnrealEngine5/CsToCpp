namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Acceleration/ParticleModuleAccelerationDrag.h")]
public partial class UParticleModuleAccelerationDrag : UParticleModuleAccelerationBase {
	public static UClass StaticClass() {return default;}
	///<summary>Per-particle drag coefficient. Evaluted using emitter time.</summary>
	public UDistributionFloat DragCoefficient_DEPRECATED;
	///<summary>Per-particle drag coefficient. Evaluted using emitter time.</summary>
	public FRawDistributionFloat DragCoefficientRaw;
}
