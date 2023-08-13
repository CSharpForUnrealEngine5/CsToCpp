namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A light component which emits light from a single point equally in all directions.</summary>
[CppInclude("Components/PointLightComponent.h")]
public partial class UPointLightComponent : ULocalLightComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to use physically based inverse squared distance falloff, where AttenuationRadius is only clamping the light&#39;s contribution.</summary>
	public bool bUseInverseSquaredFalloff;
	///<summary>Controls the radial falloff of the light when UseInverseSquaredFalloff is disabled.</summary>
	public float LightFalloffExponent;
	///<summary>Radius of light source shape.</summary>
	public float SourceRadius;
	///<summary>Soft radius of light source shape.</summary>
	public float SoftSourceRadius;
	///<summary>Length of light source shape.</summary>
	public float SourceLength;
	///<summary>SetUseInverseSquaredFalloff</summary>
	public void SetUseInverseSquaredFalloff(bool bNewValue) {}
	///<summary>SetLightFalloffExponent</summary>
	public void SetLightFalloffExponent(float NewLightFalloffExponent) {}
	///<summary>SetInverseExposureBlend</summary>
	public void SetInverseExposureBlend(float NewInverseExposureBlend) {}
	///<summary>SetSourceRadius</summary>
	public void SetSourceRadius(float bNewValue) {}
	///<summary>SetSoftSourceRadius</summary>
	public void SetSoftSourceRadius(float bNewValue) {}
	///<summary>SetSourceLength</summary>
	public void SetSourceLength(float NewValue) {}
}
