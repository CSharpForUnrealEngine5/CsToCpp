namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/WidgetAnimation.h")]
public partial class UWidgetAnimation : UMovieSceneSequence {
	public static UClass StaticClass() {return default;}
	///<summary>Get the start time of this animation.</summary>
	public float GetStartTime() { return default; }
	///<summary>Get the end time of this animation.</summary>
	public float GetEndTime() { return default; }
	///<summary>These animation binding functions were added so that we could cleanly upgrade assets</summary>
	public void BindToAnimationStarted(UUserWidget Widget,FWidgetAnimationDynamicEvent Delegate) {}
	///<summary>UnbindFromAnimationStarted</summary>
	public void UnbindFromAnimationStarted(UUserWidget Widget,FWidgetAnimationDynamicEvent Delegate) {}
	///<summary>UnbindAllFromAnimationStarted</summary>
	public void UnbindAllFromAnimationStarted(UUserWidget Widget) {}
	///<summary>BindToAnimationFinished</summary>
	public void BindToAnimationFinished(UUserWidget Widget,FWidgetAnimationDynamicEvent Delegate) {}
	///<summary>UnbindFromAnimationFinished</summary>
	public void UnbindFromAnimationFinished(UUserWidget Widget,FWidgetAnimationDynamicEvent Delegate) {}
	///<summary>UnbindAllFromAnimationFinished</summary>
	public void UnbindAllFromAnimationFinished(UUserWidget Widget) {}
	///<summary>Pointer to the movie scene that controls this animation.</summary>
	public UMovieScene MovieScene;
	///<summary>AnimationBindings</summary>
	public TArray<FWidgetAnimationBinding> AnimationBindings;
	///<summary>Whether to finish evaluation on stop. This legacy value is to preserve existing asset behavior to NOT finish on stop since content was created with this bug. If this is removed, evaluation should always finish on stop.</summary>
	public bool bLegacyFinishOnStop;
	///<summary>The friendly name for this animation displayed in the designer.</summary>
	public string DisplayLabel;
}
