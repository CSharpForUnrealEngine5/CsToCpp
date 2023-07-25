#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRDeviceVisualizationComponent.h")]
public partial class UXRDeviceVisualizationComponent : UStaticMeshComponent {
// XRDeviceVisualizationComponent
	public bool bIsVisualizationActive;
	public void SetIsVisualizationActive(bool bNewVisualizationState) {}
	public string DisplayModelSource;
	public void SetDisplayModelSource(string NewDisplayModelSource) {}
	public UStaticMesh CustomDisplayMesh;
	public void SetCustomDisplayMesh(UObject NewDisplayMesh) {}
	public TArray<UMaterialInterface> DisplayMeshMaterialOverrides;
	public void SetIsRenderingActive(bool bRenderingIsActive) {}
}
