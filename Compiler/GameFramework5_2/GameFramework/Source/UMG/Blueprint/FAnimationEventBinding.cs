namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to manage different animation event bindings that users want callbacks on.</summary>
[CppInclude("Blueprint/UserWidget.h")]
public partial struct FAnimationEventBinding {
	public UWidgetAnimation Animation;
	public FWidgetAnimationDynamicEvent Delegate;
	public EWidgetAnimationEvent AnimationEvent;
	public string UserTag;
}
