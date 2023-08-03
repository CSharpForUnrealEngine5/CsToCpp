#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Acceleration/ParticleModuleAccelerationDragScaleOverLife.h")]
public partial class UParticleModuleAccelerationDragScaleOverLife : UParticleModuleAccelerationBase {
	public static UClass StaticClass() {return default;}
	///<summary>Per-particle drag scale. Evaluted using particle relative time.</summary>
	public UDistributionFloat DragScale_DEPRECATED;
	///<summary>Per-particle drag scale. Evaluted using particle relative time.</summary>
	public FRawDistributionFloat DragScaleRaw;
}
