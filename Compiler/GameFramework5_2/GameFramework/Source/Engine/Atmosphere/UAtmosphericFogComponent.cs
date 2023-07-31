#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to create fogging effects such as clouds.</summary>
[CppInclude("Atmosphere/AtmosphericFogComponent.h")]
public partial class UAtmosphericFogComponent : USkyAtmosphereComponent {
	///<summary>Deprecated</summary>
	public  void SetDefaultBrightness(float NewBrightness) {}
	///<summary>Deprecated</summary>
	public  void SetDefaultLightColor(FLinearColor NewLightColor) {}
	///<summary>Deprecated</summary>
	public  void SetSunMultiplier(float NewSunMultiplier) {}
	///<summary>Deprecated</summary>
	public  void SetFogMultiplier(float NewFogMultiplier) {}
	///<summary>Deprecated</summary>
	public  void SetDensityMultiplier(float NewDensityMultiplier) {}
	///<summary>Deprecated</summary>
	public  void SetDensityOffset(float NewDensityOffset) {}
	///<summary>Deprecated</summary>
	public  void SetDistanceScale(float NewDistanceScale) {}
	///<summary>Deprecated</summary>
	public  void SetAltitudeScale(float NewAltitudeScale) {}
	///<summary>Deprecated</summary>
	public  void SetStartDistance(float NewStartDistance) {}
	///<summary>Deprecated</summary>
	public  void SetDistanceOffset(float NewDistanceOffset) {}
	///<summary>Deprecated</summary>
	public  void DisableSunDisk(bool NewSunDisk) {}
	///<summary>Deprecated</summary>
	public  void DisableGroundScattering(bool NewGroundScattering) {}
	///<summary>Deprecated</summary>
	public  void SetPrecomputeParams(float DensityHeight,int MaxScatteringOrder,int InscatterAltitudeSampleNum) {}
}
