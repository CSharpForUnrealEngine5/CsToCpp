#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDensityNoise.h")]
public partial class UPCGDensityNoiseSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Density = (OriginalDensity op DensityNoise), DensityNoise in [DensityNoiseMin, DensityNoiseMax]</summary>
	public EPCGDensityNoiseMode DensityMode;
	///<summary>DensityNoiseMin</summary>
	public float DensityNoiseMin;
	///<summary>DensityNoiseMax</summary>
	public float DensityNoiseMax;
	///<summary>Density = 1 - Density before applying the DensityMode operation</summary>
	public bool bInvertSourceDensity;
}
