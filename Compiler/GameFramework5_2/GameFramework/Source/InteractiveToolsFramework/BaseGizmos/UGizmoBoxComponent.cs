#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoBoxComponent.h")]
///<summary>Simple Component intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoBoxComponent : UGizmoBaseComponent {
// GizmoBoxComponent
	public FVector Origin;
	public FQuat Rotation;
	public FVector Dimensions;
	public float LineThickness;
	public bool bRemoveHiddenLines;
	public bool bEnableAxisFlip;
}
