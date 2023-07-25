#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/WidgetAnimationPlayCallbackProxy.h")]
public partial class UWidgetAnimationPlayCallbackProxy : UObject {
// WidgetAnimationPlayCallbackProxy
	public FWidgetAnimationResult Finished;
	public UObject CreatePlayAnimationProxyObject(UObject Result,UObject Widget,UObject InAnimation,float StartAtTime/*=0.0f*/,int NumLoopsToPlay/*=1*/,EUMGSequencePlayMode PlayMode/*=EUMGSequencePlayMode.Forward*/,float PlaybackSpeed/*=1.0f*/) { return default; }
	public UObject CreatePlayAnimationTimeRangeProxyObject(UObject Result,UObject Widget,UObject InAnimation,float StartAtTime/*=0.0f*/,float EndAtTime/*=0.0f*/,int NumLoopsToPlay/*=1*/,EUMGSequencePlayMode PlayMode/*=EUMGSequencePlayMode.Forward*/,float PlaybackSpeed/*=1.0f*/) { return default; }
}
