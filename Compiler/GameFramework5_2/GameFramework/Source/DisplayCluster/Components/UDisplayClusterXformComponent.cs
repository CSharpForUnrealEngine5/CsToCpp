#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DisplayClusterXformComponent.h")]
///<summary>nDisplay Transform component</summary>
public partial class UDisplayClusterXformComponent : USceneComponent {
// DisplayClusterXformComponent
	public bool bEnableGizmo;
	public FVector BaseGizmoScale;
	public float GizmoScaleMultiplier;
	public UStaticMesh ProxyMesh;
	public UStaticMeshComponent ProxyMeshComponent;
}
