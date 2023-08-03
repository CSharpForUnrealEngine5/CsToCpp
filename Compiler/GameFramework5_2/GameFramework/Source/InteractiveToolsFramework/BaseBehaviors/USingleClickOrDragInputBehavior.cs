#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USingleClickOrDragInputBehavior is a combination of a USingleClickBehavior and UClickDragBehavior,</summary>
[CppInclude("BaseBehaviors/SingleClickOrDragBehavior.h")]
public partial class USingleClickOrDragInputBehavior : UAnyButtonInputBehavior {
	public static UClass StaticClass() {return default;}
	///<summary>If true (default), then if the click-mouse-down does not hit a valid click target (determined by IClickBehaviorTarget::IsHitByClick), then the Drag will be initiated</summary>
	public bool bBeginDragIfClickTargetNotHit;
	///<summary>If the device moves more than this distance in 2D (pixel?) units, the interaction switches from click to drag</summary>
	public float ClickDistanceThreshold;
}
