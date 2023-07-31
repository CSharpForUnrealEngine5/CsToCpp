#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Adapted from URectangleMarqueeMechanic, the mechanic for a rectangle &quot;marquee&quot; selection, to operate without</summary>
[CppInclude("FractureToolSelection.h")]
public partial class URectangleMarqueeManager : UObject {
	///<summary>If true, then the URectangleMarqueeManager will not create an internal UClickDragInputBehavior in ::Setup(), allowing</summary>
	public bool bUseExternalClickDragBehavior;
	///<summary>If the computation time for a single call to OnDragRectangleChanged ever exceeds this threshold then future calls</summary>
	public double OnDragRectangleChangedDeferredThreshold;
	///<summary>ClickDragBehavior</summary>
	public UClickDragInputBehavior ClickDragBehavior;
}
