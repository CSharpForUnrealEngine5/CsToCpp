#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/WidgetAnimationPlayCallbackProxy.h")]
public partial class UWidgetAnimationPlayCallbackProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when animation has been completed</summary>
	public FWidgetAnimationResult Finished;
	///<summary>Play Animation and trigger event on Finished</summary>
	public static UWidgetAnimationPlayCallbackProxy CreatePlayAnimationProxyObject(UUMGSequencePlayer Result,UUserWidget Widget,UWidgetAnimation InAnimation,float StartAtTime/*=0.0f*/,int NumLoopsToPlay/*=1*/,EUMGSequencePlayMode PlayMode/*=EUMGSequencePlayMode.Forward*/,float PlaybackSpeed/*=1.0f*/) { return default; }
	///<summary>Play Animation Time Range and trigger event on Finished</summary>
	public static UWidgetAnimationPlayCallbackProxy CreatePlayAnimationTimeRangeProxyObject(UUMGSequencePlayer Result,UUserWidget Widget,UWidgetAnimation InAnimation,float StartAtTime/*=0.0f*/,float EndAtTime/*=0.0f*/,int NumLoopsToPlay/*=1*/,EUMGSequencePlayMode PlayMode/*=EUMGSequencePlayMode.Forward*/,float PlaybackSpeed/*=1.0f*/) { return default; }
}
