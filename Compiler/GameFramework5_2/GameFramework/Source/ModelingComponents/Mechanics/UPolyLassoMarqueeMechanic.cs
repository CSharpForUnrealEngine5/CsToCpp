#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Mechanic for a PolyLasso &quot;marquee&quot; selection. It creates and maintains the 2D PolyLasso associated with a mouse drag.</summary>
[CppInclude("Mechanics/PolyLassoMarqueeMechanic.h")]
public partial class UPolyLassoMarqueeMechanic : UInteractionMechanic {
	///<summary>Tolerance for PolyLasso points and closure test</summary>
	public float SpacingTolerance;
	///<summary>Thickness of the 2D PolyLasso drawing path</summary>
	public float LineThickness;
	///<summary>PolyLasso path is drawn in this color</summary>
	public FLinearColor LineColor;
	///<summary>PolyLasso path is drawn in this color if the cursor is at a point that would close the loop</summary>
	public FLinearColor ClosedColor;
	///<summary>If true, freehand polygons can be drawn by click-dragging the mouse</summary>
	public bool bEnableFreehandPolygons;
	///<summary>If true, if click and release are within SpacingTolerance, mechanic enters a multi-click mode,</summary>
	public bool bEnableMultiClickPolygons;
	///<summary>ClickDragBehavior</summary>
	public UClickDragInputBehavior ClickDragBehavior;
	///<summary>HoverBehavior</summary>
	public UMouseHoverBehavior HoverBehavior;
}
