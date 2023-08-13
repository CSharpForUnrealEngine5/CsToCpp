namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A light component which emits light from a single point equally in all directions.</summary>
[CppInclude("Components/LocalLightComponent.h")]
public partial class ULocalLightComponent : ULightComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Units used for the intensity.</summary>
	public ELightUnits IntensityUnits;
	///<summary>Blend Factor used to blend between Intensity and Intensity/Exposure.</summary>
	public float InverseExposureBlend;
	///<summary>Radius_DEPRECATED</summary>
	public float Radius_DEPRECATED;
	///<summary>Bounds the light&#39;s visible influence.</summary>
	public float AttenuationRadius;
	///<summary>The Lightmass settings for this object.</summary>
	public FLightmassPointLightSettings LightmassSettings;
	///<summary>SetAttenuationRadius</summary>
	public void SetAttenuationRadius(float NewRadius) {}
	///<summary>Set the units used for the intensity of the light</summary>
	public void SetIntensityUnits(ELightUnits NewIntensityUnits) {}
	///<summary>GetUnitsConversionFactor</summary>
	public static float GetUnitsConversionFactor(ELightUnits SrcUnits,ELightUnits TargetUnits,float CosHalfConeAngle/*=-1f*/) { return default; }
}
