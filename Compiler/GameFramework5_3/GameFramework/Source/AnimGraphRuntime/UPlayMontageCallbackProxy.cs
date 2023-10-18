namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlayMontageCallbackProxy.h")]
public partial class UPlayMontageCallbackProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Called when Montage finished playing and wasn&#39;t interrupted</summary>
	public FOnMontagePlayDelegate OnCompleted;
	///<summary>Called when Montage starts blending out and is not interrupted</summary>
	public FOnMontagePlayDelegate OnBlendOut;
	///<summary>Called when Montage has been interrupted (or failed to play)</summary>
	public FOnMontagePlayDelegate OnInterrupted;
	///<summary>OnNotifyBegin</summary>
	public FOnMontagePlayDelegate OnNotifyBegin;
	///<summary>OnNotifyEnd</summary>
	public FOnMontagePlayDelegate OnNotifyEnd;
	///<summary>Called to perform the query internally</summary>
	public static UPlayMontageCallbackProxy CreateProxyObjectForPlayMontage(USkeletalMeshComponent InSkeletalMeshComponent,UAnimMontage MontageToPlay,float PlayRate/*=1.0f*/,float StartingPosition/*=0.0f*/,FName StartingSection/*=NAME_None*/) { return default; }
	///<summary>OnMontageBlendingOut</summary>
	public void OnMontageBlendingOut(UAnimMontage Montage,bool bInterrupted) {}
	///<summary>OnMontageEnded</summary>
	public void OnMontageEnded(UAnimMontage Montage,bool bInterrupted) {}
	///<summary>OnNotifyBeginReceived</summary>
	public void OnNotifyBeginReceived(FName NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
	///<summary>OnNotifyEndReceived</summary>
	public void OnNotifyEndReceived(FName NotifyName,FBranchingPointNotifyPayload BranchingPointNotifyPayload) {}
}
