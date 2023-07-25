#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LocalLightComponent.h")]
///<summary>A light component which emits light from a single point equally in all directions.</summary>
public partial class ULocalLightComponent : ULightComponent {
// LocalLightComponent
	public ELightUnits IntensityUnits;
	public float InverseExposureBlend;
	public float Radius_DEPRECATED;
	public float AttenuationRadius;
	public FLightmassPointLightSettings LightmassSettings;
	public void SetAttenuationRadius(float NewRadius) {}
	public void SetIntensityUnits(ELightUnits NewIntensityUnits) {}
	public float GetUnitsConversionFactor(ELightUnits SrcUnits,ELightUnits TargetUnits,float CosHalfConeAngle/*=-1f*/) { return default; }
}
