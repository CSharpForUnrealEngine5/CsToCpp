#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UBaseDynamicMeshComponent is a base interface for a UMeshComponent based on a UDynamicMesh.</summary>
[CppInclude("Components/BaseDynamicMeshComponent.h")]
public partial class UBaseDynamicMeshComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>@return the child UDynamicMesh</summary>
	public  UDynamicMesh GetDynamicMesh() { return default; }
	///<summary>If true, render the Wireframe on top of the Shaded Mesh</summary>
	public bool bExplicitShowWireframe;
	///<summary>Configure whether wireframe rendering is enabled or not</summary>
	public  void SetEnableWireframeRenderPass(bool bEnable) {}
	///<summary>@return true if wireframe rendering pass is enabled</summary>
	public  bool GetEnableWireframeRenderPass() { return default; }
	///<summary>Constant Color used when Override Color Mode is set to Constant</summary>
	public FLinearColor WireframeColor;
	///<summary>ColorMode</summary>
	public EDynamicMeshComponentColorOverrideMode ColorMode;
	///<summary>Configure the active Color Override</summary>
	public  void SetColorOverrideMode(EDynamicMeshComponentColorOverrideMode NewMode) {}
	///<summary>@return active Color Override mode</summary>
	public  EDynamicMeshComponentColorOverrideMode GetColorOverrideMode() { return default; }
	///<summary>Constant Color used when Override Color Mode is set to Constant</summary>
	public FColor ConstantColor;
	///<summary>Configure the Color used with Constant Color Override Mode</summary>
	public  void SetConstantOverrideColor(FColor NewColor) {}
	///<summary>@return active Color used for Constant Color Override Mode</summary>
	public  FColor GetConstantOverrideColor() { return default; }
	///<summary>Enable use of per-triangle facet normals in place of mesh normals</summary>
	public bool bEnableFlatShading;
	///<summary>Configure the Color used with Constant Color Override Mode</summary>
	public  void SetEnableFlatShading(bool bEnable) {}
	///<summary>@return active Color used for Constant Color Override Mode</summary>
	public  bool GetFlatShadingEnabled() { return default; }
	///<summary>SetShadowsEnabled</summary>
	public  void SetShadowsEnabled(bool bEnabled) {}
	///<summary>GetShadowsEnabled</summary>
	public  bool GetShadowsEnabled() { return default; }
	///<summary>SetViewModeOverridesEnabled</summary>
	public  void SetViewModeOverridesEnabled(bool bEnabled) {}
	///<summary>GetViewModeOverridesEnabled</summary>
	public  bool GetViewModeOverridesEnabled() { return default; }
	///<summary>This flag controls whether Editor View Mode Overrides are enabled for this mesh. For example, this controls hidden-line removal on the wireframe</summary>
	public bool bEnableViewModeOverrides;
	///<summary>Set an active override render material. This should replace all materials during rendering.</summary>
	public  void SetOverrideRenderMaterial(UMaterialInterface Material) {}
	///<summary>Clear any active override render material</summary>
	public  void ClearOverrideRenderMaterial() {}
	///<summary>@return true if an override render material is currently enabled for the given MaterialIndex</summary>
	public  bool HasOverrideRenderMaterial(int k) { return default; }
	///<summary>@return active override render material for the given MaterialIndex</summary>
	public  UMaterialInterface GetOverrideRenderMaterial(int MaterialIndex) { return default; }
	///<summary>OverrideRenderMaterial</summary>
	public UMaterialInterface OverrideRenderMaterial;
	///<summary>Set an active secondary render material.</summary>
	public  void SetSecondaryRenderMaterial(UMaterialInterface Material) {}
	///<summary>Clear any active secondary render material</summary>
	public  void ClearSecondaryRenderMaterial() {}
	///<summary>@return active secondary render material</summary>
	public  UMaterialInterface GetSecondaryRenderMaterial() { return default; }
	///<summary>Show/Hide the secondary triangle buffers. Does not invalidate SceneProxy.</summary>
	public  void SetSecondaryBuffersVisibility(bool bSetVisible) {}
	///<summary>@return true if secondary buffers are currently set to be visible</summary>
	public  bool GetSecondaryBuffersVisibility() { return default; }
	///<summary>SecondaryRenderMaterial</summary>
	public UMaterialInterface SecondaryRenderMaterial;
	///<summary>Enable/disable Raytracing support on this Mesh, if Raytracing is currently enabled in the Project Settings.</summary>
	public bool bEnableRaytracing;
	///<summary>Enable/Disable raytracing support. This is an expensive call as it flushes</summary>
	public  void SetEnableRaytracing(bool bSetEnabled) {}
	///<summary>@return true if raytracing support is currently enabled</summary>
	public  bool GetEnableRaytracing() { return default; }
	///<summary>BaseMaterials</summary>
	public TArray<UMaterialInterface> BaseMaterials;
}
