#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/UserWidget.h")]
///<summary>Used to manage different animation event bindings that users want callbacks on.</summary>
public partial struct FAnimationEventBinding {
// AnimationEventBinding
	public UWidgetAnimation Animation;
	public FWidgetAnimationDynamicEvent Delegate;
	public EWidgetAnimationEvent AnimationEvent;
	public string UserTag;
}
