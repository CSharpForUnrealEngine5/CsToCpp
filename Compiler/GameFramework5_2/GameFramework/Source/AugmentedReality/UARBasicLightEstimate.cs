#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARLightEstimate.h")]
public partial class UARBasicLightEstimate : UARLightEstimate {
// ARBasicLightEstimate
	public float GetAmbientIntensityLumens() { return default; }
	public float GetAmbientColorTemperatureKelvin() { return default; }
	public FLinearColor GetAmbientColor() { return default; }
	public float AmbientIntensityLumens;
	public float AmbientColorTemperatureKelvin;
	public FLinearColor AmbientColor;
}
