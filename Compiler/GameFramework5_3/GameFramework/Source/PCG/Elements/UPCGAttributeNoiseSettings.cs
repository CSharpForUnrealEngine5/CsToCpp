namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Apply some noise to an attribute/property. You can select the mode you want and a noise range.</summary>
[CppInclude("Elements/PCGAttributeNoise.h")]
public partial class UPCGAttributeNoiseSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>InputSource</summary>
	public FPCGAttributePropertyInputSelector InputSource;
	///<summary>OutputTarget</summary>
	public FPCGAttributePropertyOutputSelector OutputTarget;
	///<summary>Attribute = (Original op Noise), Noise in [NoiseMin, NoiseMax]</summary>
	public EPCGAttributeNoiseMode Mode;
	///<summary>NoiseMin</summary>
	public float NoiseMin;
	///<summary>NoiseMax</summary>
	public float NoiseMax;
	///<summary>Attribute = 1 - Attribute before applying the operation</summary>
	public bool bInvertSource;
	///<summary>Clamp the result between 0 and 1. Always applied if we apply noise to the density.</summary>
	public bool bClampResult;
	///<summary>DensityMode_DEPRECATED</summary>
	public EPCGAttributeNoiseMode DensityMode_DEPRECATED;
	///<summary>DensityNoiseMin_DEPRECATED</summary>
	public float DensityNoiseMin_DEPRECATED;
	///<summary>DensityNoiseMax_DEPRECATED</summary>
	public float DensityNoiseMax_DEPRECATED;
	///<summary>bInvertSourceDensity_DEPRECATED</summary>
	public bool bInvertSourceDensity_DEPRECATED;
	///<summary>bOutputTargetDifferentFromInputSource_DEPRECATED</summary>
	public bool bOutputTargetDifferentFromInputSource_DEPRECATED;
}
