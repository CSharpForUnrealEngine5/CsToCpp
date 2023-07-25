#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlayMontageCallbackProxy.h")]
public partial class UPlayMontageCallbackProxy : UObject {
// PlayMontageCallbackProxy
	public FOnMontagePlayDelegate OnCompleted;
	public FOnMontagePlayDelegate OnBlendOut;
	public FOnMontagePlayDelegate OnInterrupted;
	public FOnMontagePlayDelegate OnNotifyBegin;
	public FOnMontagePlayDelegate OnNotifyEnd;
	public UObject CreateProxyObjectForPlayMontage(UObject InSkeletalMeshComponent,UObject MontageToPlay,float PlayRate/*=1.0f*/,float StartingPosition/*=0.0f*/,string StartingSection/*=NAME_None*/) { return default; }
	public void OnMontageBlendingOut(UObject Montage,bool bInterrupted) {}
	public void OnMontageEnded(UObject Montage,bool bInterrupted) {}
	public void OnNotifyBeginReceived(string NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
	public void OnNotifyEndReceived(string NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
}
