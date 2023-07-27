#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PointLightComponent.h")]
///<summary>A light component which emits light from a single point equally in all directions.</summary>
public partial class UPointLightComponent : ULocalLightComponent {
// PointLightComponent
	public bool bUseInverseSquaredFalloff;
	public float LightFalloffExponent;
	public float SourceRadius;
	public float SoftSourceRadius;
	public float SourceLength;
	public  void SetUseInverseSquaredFalloff(bool bNewValue) {}
	public  void SetLightFalloffExponent(float NewLightFalloffExponent) {}
	public  void SetInverseExposureBlend(float NewInverseExposureBlend) {}
	public  void SetSourceRadius(float bNewValue) {}
	public  void SetSoftSourceRadius(float bNewValue) {}
	public  void SetSourceLength(float NewValue) {}
}
