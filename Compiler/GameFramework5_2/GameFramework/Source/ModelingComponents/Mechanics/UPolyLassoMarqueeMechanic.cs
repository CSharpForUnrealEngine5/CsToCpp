#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/PolyLassoMarqueeMechanic.h")]
///<summary>* Mechanic for a PolyLasso "marquee" selection. It creates and maintains the 2D PolyLasso associated with a mouse drag.</summary>
public partial class UPolyLassoMarqueeMechanic : UInteractionMechanic {
// PolyLassoMarqueeMechanic
	public float SpacingTolerance;
	public float LineThickness;
	public FLinearColor LineColor;
	public FLinearColor ClosedColor;
	public bool bEnableFreehandPolygons;
	public bool bEnableMultiClickPolygons;
	public UClickDragInputBehavior ClickDragBehavior;
	public UMouseHoverBehavior HoverBehavior;
}
