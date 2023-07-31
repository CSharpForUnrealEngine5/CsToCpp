#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UClickDragInputBehavior implements a standard &quot;button-click-drag&quot;-style input behavior.</summary>
[CppInclude("BaseBehaviors/ClickDragBehavior.h")]
public partial class UClickDragInputBehavior : UAnyButtonInputBehavior {
	///<summary>If true, then we will update Modifier states in UpdateCapture(). This defaults to false because</summary>
	public bool bUpdateModifiersDuringDrag;
}
