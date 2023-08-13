namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Mechanic for a rectangle &quot;marquee&quot; selection. It creates and maintains the 2D rectangle associated with a mouse drag.</summary>
[CppInclude("Mechanics/RectangleMarqueeMechanic.h")]
public partial class URectangleMarqueeMechanic : UInteractionMechanic {
	public static UClass StaticClass() {return default;}
	///<summary>If true, then the URectangleMarqueeMechanic will not create an internal UClickDragInputBehavior in ::Setup(), allowing</summary>
	public bool bUseExternalClickDragBehavior;
	///<summary>If true, then the URectangleMarqueeMechanic will not query the tool manager for the current camera view state,</summary>
	public bool bUseExternalUpdateCameraState;
	///<summary>If the computation time for a single call to OnDragRectangleChanged ever exceeds this threshold then future calls</summary>
	public double OnDragRectangleChangedDeferredThreshold;
	///<summary>ClickDragBehavior</summary>
	public UClickDragInputBehavior ClickDragBehavior;
}
