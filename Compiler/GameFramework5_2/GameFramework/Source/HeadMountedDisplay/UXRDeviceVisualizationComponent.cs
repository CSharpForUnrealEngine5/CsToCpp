#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRDeviceVisualizationComponent.h")]
public partial class UXRDeviceVisualizationComponent : UStaticMeshComponent {
	///<summary>Whether the visualization offered by this component is being used.</summary>
	public bool bIsVisualizationActive;
	///<summary>SetIsVisualizationActive</summary>
	public  void SetIsVisualizationActive(bool bNewVisualizationState) {}
	///<summary>Determines the source of the desired model. By default, the active XR system(s) will be queried and (if available) will provide a model for the associated device. NOTE: this may fail if there&#39;s no default model; use &#39;Custom&#39; to specify your own.</summary>
	public string DisplayModelSource;
	///<summary>SetDisplayModelSource</summary>
	public  void SetDisplayModelSource(string NewDisplayModelSource) {}
	///<summary>A mesh override that&#39;ll be displayed attached to this MotionController.</summary>
	public UStaticMesh CustomDisplayMesh;
	///<summary>SetCustomDisplayMesh</summary>
	public  void SetCustomDisplayMesh(UStaticMesh NewDisplayMesh) {}
	///<summary>Material overrides for the specified display mesh.</summary>
	public TArray<UMaterialInterface> DisplayMeshMaterialOverrides;
	///<summary>SetIsRenderingActive</summary>
	public  void SetIsRenderingActive(bool bRenderingIsActive) {}
}
