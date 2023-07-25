#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DisplayClusterOriginComponent.h")]
///<summary>nDisplay origin component (mostly for in-Editor visualization)</summary>
public partial class UDisplayClusterOriginComponent : USceneComponent {
// DisplayClusterOriginComponent
	public bool bEnableGizmo;
	public FVector BaseGizmoScale;
	public float GizmoScaleMultiplier;
	public UStaticMesh ProxyMesh;
	public UStaticMeshComponent ProxyMeshComponent;
}
