#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Acceleration/ParticleModuleAccelerationDrag.h")]
public partial class UParticleModuleAccelerationDrag : UParticleModuleAccelerationBase {
	///<summary>Per-particle drag coefficient. Evaluted using emitter time.</summary>
	public UDistributionFloat DragCoefficient_DEPRECATED;
	///<summary>Per-particle drag coefficient. Evaluted using emitter time.</summary>
	public FRawDistributionFloat DragCoefficientRaw;
}
