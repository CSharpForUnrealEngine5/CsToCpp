#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DecalComponent.h")]
///<summary>A material that is rendered onto the surface of a mesh. A kind of 'bumper sticker' for a model.</summary>
public partial class UDecalComponent : USceneComponent {
// DecalComponent
	public UMaterialInterface DecalMaterial;
	public int SortOrder;
	public float FadeScreenSize;
	public float FadeStartDelay;
	public float FadeDuration;
	public float FadeInDuration;
	public float FadeInStartDelay;
	public bool bDestroyOwnerAfterFade;
	public  float GetFadeStartDelay() { return default; }
	public  float GetFadeDuration() { return default; }
	public  float GetFadeInStartDelay() { return default; }
	public  float GetFadeInDuration() { return default; }
	public FVector DecalSize;
	public FLinearColor DecalColor;
	public  void SetFadeOut(float StartDelay,float Duration,bool DestroyOwnerAfterFade/*=true*/) {}
	public  void SetFadeIn(float StartDelay,float Duration) {}
	public  void SetFadeScreenSize(float NewFadeScreenSize) {}
	public  void SetSortOrder(int Value) {}
	public  void SetDecalColor(FLinearColor Color) {}
	public  void SetDecalMaterial(UMaterialInterface NewDecalMaterial) {}
	public  UMaterialInterface GetDecalMaterial() { return default; }
	public  UMaterialInstanceDynamic CreateDynamicMaterialInstance() { return default; }
}
