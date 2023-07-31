#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Light.h")]
public partial class ALight : AActor {
	///<summary>@todo document</summary>
	public ULightComponent LightComponent;
	///<summary>replicated copy of LightComponent&#39;s bEnabled property</summary>
	public bool bEnabled;
	///<summary>Replication Notification Callbacks</summary>
	public  void OnRep_bEnabled() {}
	///<summary>BEGIN DEPRECATED (use component functions now in level script)</summary>
	public  void SetEnabled(bool bSetEnabled) {}
	///<summary>IsEnabled</summary>
	public  bool IsEnabled() { return default; }
	///<summary>ToggleEnabled</summary>
	public  void ToggleEnabled() {}
	///<summary>SetBrightness</summary>
	public  void SetBrightness(float NewBrightness) {}
	///<summary>GetBrightness</summary>
	public  float GetBrightness() { return default; }
	///<summary>SetLightColor</summary>
	public  void SetLightColor(FLinearColor NewLightColor) {}
	///<summary>GetLightColor</summary>
	public  FLinearColor GetLightColor() { return default; }
	///<summary>SetLightFunctionMaterial</summary>
	public  void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial) {}
	///<summary>SetLightFunctionScale</summary>
	public  void SetLightFunctionScale(FVector NewLightFunctionScale) {}
	///<summary>SetLightFunctionFadeDistance</summary>
	public  void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance) {}
	///<summary>SetCastShadows</summary>
	public  void SetCastShadows(bool bNewValue) {}
	///<summary>SetAffectTranslucentLighting</summary>
	public  void SetAffectTranslucentLighting(bool bNewValue) {}
}
