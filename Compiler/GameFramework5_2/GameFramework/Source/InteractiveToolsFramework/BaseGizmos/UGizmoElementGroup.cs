#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple group object intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementGroup.h")]
public partial class UGizmoElementGroup : UGizmoElementLineBase {
	public static UClass StaticClass() {return default;}
	///<summary>When true, maintains view-dependent constant scale for this gizmo object hierarchy</summary>
	public bool bConstantScale;
	///<summary>When true, this group is treated as a single element such that when LineTrace is called, if any of its sub-elements is hit,</summary>
	public bool bHitOwner;
	///<summary>Gizmo elements within this group</summary>
	public TArray<UGizmoElementBase> Elements;
}
