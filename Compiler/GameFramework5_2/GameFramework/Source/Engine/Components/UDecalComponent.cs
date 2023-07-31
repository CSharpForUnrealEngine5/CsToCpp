#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material that is rendered onto the surface of a mesh. A kind of &#39;bumper sticker&#39; for a model.</summary>
[CppInclude("Components/DecalComponent.h")]
public partial class UDecalComponent : USceneComponent {
	///<summary>Decal material.</summary>
	public UMaterialInterface DecalMaterial;
	///<summary>Controls the order in which decal elements are rendered.  Higher values draw later (on top).</summary>
	public int SortOrder;
	///<summary>FadeScreenSize</summary>
	public float FadeScreenSize;
	///<summary>Time in seconds to wait before beginning to fade out the decal. Set fade duration and start delay to 0 to make persistent.</summary>
	public float FadeStartDelay;
	///<summary>Time in seconds for the decal to fade out. Set fade duration and start delay to 0 to make persistent. Only fades in active simulation or game.</summary>
	public float FadeDuration;
	///<summary>FadeInDuration</summary>
	public float FadeInDuration;
	///<summary>FadeInStartDelay</summary>
	public float FadeInStartDelay;
	///<summary>Automatically destroys the owning actor after fully fading out.</summary>
	public bool bDestroyOwnerAfterFade;
	///<summary>GetFadeStartDelay</summary>
	public  float GetFadeStartDelay() { return default; }
	///<summary>GetFadeDuration</summary>
	public  float GetFadeDuration() { return default; }
	///<summary>GetFadeInStartDelay</summary>
	public  float GetFadeInStartDelay() { return default; }
	///<summary>GetFadeInDuration</summary>
	public  float GetFadeInDuration() { return default; }
	///<summary>Decal size in local space (does not include the component scale), technically redundant but there for convenience</summary>
	public FVector DecalSize;
	///<summary>Decal color, can be accessed using the material Decal Color node.</summary>
	public FLinearColor DecalColor;
	///<summary>Sets the decal&#39;s fade start time, duration and if the owning actor should be destroyed after the decal is fully faded out.</summary>
	public  void SetFadeOut(float StartDelay,float Duration,bool DestroyOwnerAfterFade/*=true*/) {}
	///<summary>SetFadeIn</summary>
	public  void SetFadeIn(float StartDelay,float Duration) {}
	///<summary>Set the FadeScreenSize for this decal component</summary>
	public  void SetFadeScreenSize(float NewFadeScreenSize) {}
	///<summary>Sets the sort order for the decal component. Higher values draw later (on top). This will force the decal to reattach</summary>
	public  void SetSortOrder(int Value) {}
	///<summary>Sets the decal color.</summary>
	public  void SetDecalColor(FLinearColor Color) {}
	///<summary>setting decal material on decal component. This will force the decal to reattach</summary>
	public  void SetDecalMaterial(UMaterialInterface NewDecalMaterial) {}
	///<summary>Accessor for decal material</summary>
	public  UMaterialInterface GetDecalMaterial() { return default; }
	///<summary>Utility to allocate a new Dynamic Material Instance, set its parent to the currently applied material, and assign it</summary>
	public  UMaterialInstanceDynamic CreateDynamicMaterialInstance() { return default; }
}
