#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for 2d and 3d primitive objects which support line drawing,</summary>
[CppInclude("BaseGizmos/GizmoElementLineBase.h")]
public partial class UGizmoElementLineBase : UGizmoElementBase {
	public static UClass StaticClass() {return default;}
	///<summary>Line render state attributes for this element</summary>
	public FGizmoElementLineRenderStateAttributes LineRenderAttributes;
	///<summary>Line thickness when rendering lines, must be &gt;= 0.0, value of 0.0 will render thinnest line</summary>
	public float LineThickness;
	///<summary>Whether line thickness is in screen space</summary>
	public bool bScreenSpaceLine;
	///<summary>Multiplier applied to line thickness when hovering</summary>
	public float HoverLineThicknessMultiplier;
	///<summary>Multiplier applied to line thickness when interacting</summary>
	public float InteractLineThicknessMultiplier;
}
