#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementGroup.h")]
///<summary>Simple group object intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoElementGroup : UGizmoElementLineBase {
// GizmoElementGroup
	public bool bConstantScale;
	public bool bHitOwner;
	public TArray<UGizmoElementBase> Elements;
}
