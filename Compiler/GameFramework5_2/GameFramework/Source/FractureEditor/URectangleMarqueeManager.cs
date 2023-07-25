#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolSelection.h")]
///<summary>* Adapted from URectangleMarqueeMechanic, the mechanic for a rectangle "marquee" selection, to operate without</summary>
public partial class URectangleMarqueeManager : UObject {
// RectangleMarqueeManager
	public bool bUseExternalClickDragBehavior;
	public double OnDragRectangleChangedDeferredThreshold;
	public UClickDragInputBehavior ClickDragBehavior;
}
