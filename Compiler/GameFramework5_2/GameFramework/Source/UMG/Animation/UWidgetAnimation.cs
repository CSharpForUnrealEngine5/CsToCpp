#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/WidgetAnimation.h")]
public partial class UWidgetAnimation : UMovieSceneSequence {
// WidgetAnimation
	public float GetStartTime() { return default; }
	public float GetEndTime() { return default; }
	public void BindToAnimationStarted(UObject Widget,FWidgetAnimationDynamicEvent Delegate) {}
	public void UnbindFromAnimationStarted(UObject Widget,FWidgetAnimationDynamicEvent Delegate) {}
	public void UnbindAllFromAnimationStarted(UObject Widget) {}
	public void BindToAnimationFinished(UObject Widget,FWidgetAnimationDynamicEvent Delegate) {}
	public void UnbindFromAnimationFinished(UObject Widget,FWidgetAnimationDynamicEvent Delegate) {}
	public void UnbindAllFromAnimationFinished(UObject Widget) {}
	public UMovieScene MovieScene;
	public TArray<FWidgetAnimationBinding> AnimationBindings;
	public bool bLegacyFinishOnStop;
	public string DisplayLabel;
}
