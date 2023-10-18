namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSingleNodeInstance.h")]
public partial class UAnimSingleNodeInstance : UAnimInstance {
	public static UClass StaticClass() {return default;}
	///<summary>Current Asset being played *</summary>
	public UAnimationAsset CurrentAsset;
	///<summary>PostEvaluateAnimEvent</summary>
	public FPostEvaluateAnimEvent PostEvaluateAnimEvent;
	///<summary>SetMirrorDataTable</summary>
	public void SetMirrorDataTable(UMirrorDataTable MirrorDataTable) {}
	///<summary>GetMirrorDataTable</summary>
	public UMirrorDataTable GetMirrorDataTable() { return default; }
	///<summary>SetLooping</summary>
	public void SetLooping(bool bIsLooping) {}
	///<summary>SetPlayRate</summary>
	public void SetPlayRate(float InPlayRate) {}
	///<summary>SetReverse</summary>
	public void SetReverse(bool bInReverse) {}
	///<summary>SetPosition</summary>
	public void SetPosition(float InPosition,bool bFireNotifies/*=true*/) {}
	///<summary>SetPositionWithPreviousTime</summary>
	public void SetPositionWithPreviousTime(float InPosition,float InPreviousTime,bool bFireNotifies/*=true*/) {}
	///<summary>SetBlendSpacePosition</summary>
	public void SetBlendSpacePosition(FVector InPosition) {}
	///<summary>SetPlaying</summary>
	public void SetPlaying(bool bIsPlaying) {}
	///<summary>GetLength</summary>
	public float GetLength() { return default; }
	///<summary>For AnimSequence specific *</summary>
	public void PlayAnim(bool bIsLooping/*=false*/,float InPlayRate/*=1.0f*/,float InStartPosition/*=0.0f*/) {}
	///<summary>StopAnim</summary>
	public void StopAnim() {}
	///<summary>Set New Asset - calls InitializeAnimation, for now we need MeshComponent *</summary>
	public virtual void SetAnimationAsset(UAnimationAsset NewAsset,bool bIsLooping/*=true*/,float InPlayRate/*=1.0f*/) {}
	///<summary>Get the currently used asset</summary>
	public virtual UAnimationAsset GetAnimationAsset() { return default; }
	///<summary>Set pose value</summary>
	public void SetPreviewCurveOverride(FName PoseName,float Value,bool bRemoveIfZero) {}
}
