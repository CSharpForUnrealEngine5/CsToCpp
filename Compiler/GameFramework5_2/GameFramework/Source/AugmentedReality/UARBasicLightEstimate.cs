#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARLightEstimate.h")]
public partial class UARBasicLightEstimate : UARLightEstimate {
	public static UClass StaticClass() {return default;}
	///<summary>GetAmbientIntensityLumens</summary>
	public  float GetAmbientIntensityLumens() { return default; }
	///<summary>GetAmbientColorTemperatureKelvin</summary>
	public  float GetAmbientColorTemperatureKelvin() { return default; }
	///<summary>GetAmbientColor</summary>
	public  FLinearColor GetAmbientColor() { return default; }
	///<summary>AmbientIntensityLumens</summary>
	public float AmbientIntensityLumens;
	///<summary>AmbientColorTemperatureKelvin</summary>
	public float AmbientColorTemperatureKelvin;
	///<summary>AmbientColor</summary>
	public FLinearColor AmbientColor;
}
