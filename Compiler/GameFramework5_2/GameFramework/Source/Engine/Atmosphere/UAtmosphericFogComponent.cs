#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Atmosphere/AtmosphericFogComponent.h")]
///<summary>Used to create fogging effects such as clouds.</summary>
public partial class UAtmosphericFogComponent : USkyAtmosphereComponent {
// AtmosphericFogComponent
	public void SetDefaultBrightness(float NewBrightness) {}
	public void SetDefaultLightColor(FLinearColor NewLightColor) {}
	public void SetSunMultiplier(float NewSunMultiplier) {}
	public void SetFogMultiplier(float NewFogMultiplier) {}
	public void SetDensityMultiplier(float NewDensityMultiplier) {}
	public void SetDensityOffset(float NewDensityOffset) {}
	public void SetDistanceScale(float NewDistanceScale) {}
	public void SetAltitudeScale(float NewAltitudeScale) {}
	public void SetStartDistance(float NewStartDistance) {}
	public void SetDistanceOffset(float NewDistanceOffset) {}
	public void DisableSunDisk(bool NewSunDisk) {}
	public void DisableGroundScattering(bool NewGroundScattering) {}
	public void SetPrecomputeParams(float DensityHeight,int MaxScatteringOrder,int InscatterAltitudeSampleNum) {}
}
