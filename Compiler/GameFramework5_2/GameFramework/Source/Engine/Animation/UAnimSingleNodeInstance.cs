#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSingleNodeInstance.h")]
public partial class UAnimSingleNodeInstance : UAnimInstance {
// AnimSingleNodeInstance
	public UAnimationAsset CurrentAsset;
	public FPostEvaluateAnimEvent PostEvaluateAnimEvent;
	public  void SetMirrorDataTable(UMirrorDataTable MirrorDataTable) {}
	public  UMirrorDataTable GetMirrorDataTable() { return default; }
	public  void SetLooping(bool bIsLooping) {}
	public  void SetPlayRate(float InPlayRate) {}
	public  void SetReverse(bool bInReverse) {}
	public  void SetPosition(float InPosition,bool bFireNotifies/*=true*/) {}
	public  void SetPositionWithPreviousTime(float InPosition,float InPreviousTime,bool bFireNotifies/*=true*/) {}
	public  void SetBlendSpacePosition(FVector InPosition) {}
	public  void SetPlaying(bool bIsPlaying) {}
	public  float GetLength() { return default; }
	public  void PlayAnim(bool bIsLooping/*=false*/,float InPlayRate/*=1.0f*/,float InStartPosition/*=0.0f*/) {}
	public  void StopAnim() {}
	public  void SetAnimationAsset(UAnimationAsset NewAsset,bool bIsLooping/*=true*/,float InPlayRate/*=1.0f*/) {}
	public  UAnimationAsset GetAnimationAsset() { return default; }
	public  void SetPreviewCurveOverride(string PoseName,float Value,bool bRemoveIfZero) {}
}
