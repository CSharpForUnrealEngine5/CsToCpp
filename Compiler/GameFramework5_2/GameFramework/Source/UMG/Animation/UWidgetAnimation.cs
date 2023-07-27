#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/WidgetAnimation.h")]
public partial class UWidgetAnimation : UMovieSceneSequence {
// WidgetAnimation
	public  float GetStartTime() { return default; }
	public  float GetEndTime() { return default; }
	public  void BindToAnimationStarted(UUserWidget Widget,FWidgetAnimationDynamicEvent Delegate) {}
	public  void UnbindFromAnimationStarted(UUserWidget Widget,FWidgetAnimationDynamicEvent Delegate) {}
	public  void UnbindAllFromAnimationStarted(UUserWidget Widget) {}
	public  void BindToAnimationFinished(UUserWidget Widget,FWidgetAnimationDynamicEvent Delegate) {}
	public  void UnbindFromAnimationFinished(UUserWidget Widget,FWidgetAnimationDynamicEvent Delegate) {}
	public  void UnbindAllFromAnimationFinished(UUserWidget Widget) {}
	public UMovieScene MovieScene;
	public TArray<FWidgetAnimationBinding> AnimationBindings;
	public bool bLegacyFinishOnStop;
	public string DisplayLabel;
}
