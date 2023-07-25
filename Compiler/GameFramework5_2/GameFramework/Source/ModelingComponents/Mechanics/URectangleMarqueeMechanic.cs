#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Mechanics/RectangleMarqueeMechanic.h")]
///<summary>* Mechanic for a rectangle "marquee" selection. It creates and maintains the 2D rectangle associated with a mouse drag.</summary>
public partial class URectangleMarqueeMechanic : UInteractionMechanic {
// RectangleMarqueeMechanic
	public bool bUseExternalClickDragBehavior;
	public bool bUseExternalUpdateCameraState;
	public double OnDragRectangleChangedDeferredThreshold;
	public UClickDragInputBehavior ClickDragBehavior;
}
