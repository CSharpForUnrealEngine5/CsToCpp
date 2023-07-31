#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCacheFunctionLibrary.h")]
public partial class UAsyncNiagaraCaptureSimCache : UBlueprintAsyncActionBase {
	///<summary>FOnCaptureComplete</summary>
	public  void FOnCaptureComplete(bool bSuccess) {}
	///<summary>CaptureSimCache</summary>
	public UNiagaraSimCache CaptureSimCache;
	///<summary>CaptureComponent</summary>
	public UNiagaraComponent CaptureComponent;
	///<summary>CaptureComplete</summary>
	public FOnCaptureComplete CaptureComplete;
	///<summary>Capture multiple frames from the provided simulation into a SimCache until the simulation becomes inactive, completes or we hit the NumFrames limit.</summary>
	public static UAsyncNiagaraCaptureSimCache CaptureNiagaraSimCacheMultiFrame(UNiagaraSimCache SimCache,FNiagaraSimCacheCreateParameters CreateParameters,UNiagaraComponent NiagaraComponent,UNiagaraSimCache OutSimCache,int NumFrames/*=16*/,int CaptureRate/*=1*/,bool bAdvanceSimulation/*=false*/,float AdvanceDeltaTime/*=0.01666f*/) { return default; }
	///<summary>Capture frames from the provided simulation into a SimCache until the simulation becomes inactive or completes.</summary>
	public static UAsyncNiagaraCaptureSimCache CaptureNiagaraSimCacheUntilComplete(UNiagaraSimCache SimCache,FNiagaraSimCacheCreateParameters CreateParameters,UNiagaraComponent NiagaraComponent,UNiagaraSimCache OutSimCache,int CaptureRate/*=1*/,bool bAdvanceSimulation/*=false*/,float AdvanceDeltaTime/*=0.01666f*/) { return default; }
}
