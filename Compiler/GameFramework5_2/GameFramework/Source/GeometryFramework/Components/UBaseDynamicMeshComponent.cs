#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BaseDynamicMeshComponent.h")]
///<summary>UBaseDynamicMeshComponent is a base interface for a UMeshComponent based on a UDynamicMesh.</summary>
public partial class UBaseDynamicMeshComponent : UMeshComponent {
// BaseDynamicMeshComponent
	public  UDynamicMesh GetDynamicMesh() { return default; }
	public bool bExplicitShowWireframe;
	public  void SetEnableWireframeRenderPass(bool bEnable) {}
	public  bool GetEnableWireframeRenderPass() { return default; }
	public FLinearColor WireframeColor;
	public EDynamicMeshComponentColorOverrideMode ColorMode;
	public  void SetColorOverrideMode(EDynamicMeshComponentColorOverrideMode NewMode) {}
	public  EDynamicMeshComponentColorOverrideMode GetColorOverrideMode() { return default; }
	public FColor ConstantColor;
	public  void SetConstantOverrideColor(FColor NewColor) {}
	public  FColor GetConstantOverrideColor() { return default; }
	public bool bEnableFlatShading;
	public  void SetEnableFlatShading(bool bEnable) {}
	public  bool GetFlatShadingEnabled() { return default; }
	public  void SetShadowsEnabled(bool bEnabled) {}
	public  bool GetShadowsEnabled() { return default; }
	public  void SetViewModeOverridesEnabled(bool bEnabled) {}
	public  bool GetViewModeOverridesEnabled() { return default; }
	public bool bEnableViewModeOverrides;
	public  void SetOverrideRenderMaterial(UMaterialInterface Material) {}
	public  void ClearOverrideRenderMaterial() {}
	public  bool HasOverrideRenderMaterial(int k) { return default; }
	public  UMaterialInterface GetOverrideRenderMaterial(int MaterialIndex) { return default; }
	public UMaterialInterface OverrideRenderMaterial;
	public  void SetSecondaryRenderMaterial(UMaterialInterface Material) {}
	public  void ClearSecondaryRenderMaterial() {}
	public  UMaterialInterface GetSecondaryRenderMaterial() { return default; }
	public  void SetSecondaryBuffersVisibility(bool bSetVisible) {}
	public  bool GetSecondaryBuffersVisibility() { return default; }
	public UMaterialInterface SecondaryRenderMaterial;
	public bool bEnableRaytracing;
	public  void SetEnableRaytracing(bool bSetEnabled) {}
	public  bool GetEnableRaytracing() { return default; }
	public TArray<UMaterialInterface> BaseMaterials;
}
