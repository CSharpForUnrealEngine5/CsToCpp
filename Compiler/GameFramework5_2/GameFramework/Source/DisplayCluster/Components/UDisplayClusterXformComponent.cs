#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>nDisplay Transform component</summary>
[CppInclude("Components/DisplayClusterXformComponent.h")]
public partial class UDisplayClusterXformComponent : USceneComponent {
	///<summary>Gizmo visibility</summary>
	public bool bEnableGizmo;
	///<summary>Base gizmo scale</summary>
	public FVector BaseGizmoScale;
	///<summary>Gizmo scale multiplier</summary>
	public float GizmoScaleMultiplier;
	///<summary>Proxy mesh to render</summary>
	public UStaticMesh ProxyMesh;
	///<summary>Proxy mesh component</summary>
	public UStaticMeshComponent ProxyMeshComponent;
}
