#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseBehaviors/SingleClickOrDragBehavior.h")]
///<summary>USingleClickOrDragInputBehavior is a combination of a USingleClickBehavior and UClickDragBehavior,</summary>
public partial class USingleClickOrDragInputBehavior : UAnyButtonInputBehavior {
// SingleClickOrDragInputBehavior
	public bool bBeginDragIfClickTargetNotHit;
	public float ClickDistanceThreshold;
}
