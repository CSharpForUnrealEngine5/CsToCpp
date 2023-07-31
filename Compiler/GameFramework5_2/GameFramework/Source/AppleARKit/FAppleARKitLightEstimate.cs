#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A light estimate represented as spherical harmonics</summary>
[CppInclude("AppleARKitLightEstimate.h")]
public partial struct FAppleARKitLightEstimate {
	public bool bIsValid;
	public float AmbientIntensity;
	public float AmbientColorTemperatureKelvin;
}
