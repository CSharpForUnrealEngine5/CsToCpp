#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementLineBase.h")]
///<summary>Base class for 2d and 3d primitive objects which support line drawing,</summary>
public partial class UGizmoElementLineBase : UGizmoElementBase {
// GizmoElementLineBase
	public FGizmoElementLineRenderStateAttributes LineRenderAttributes;
	public float LineThickness;
	public bool bScreenSpaceLine;
	public float HoverLineThicknessMultiplier;
	public float InteractLineThicknessMultiplier;
}
