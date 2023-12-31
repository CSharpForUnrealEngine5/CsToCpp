namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCacheFunctionLibrary.h")]
public partial class UAsyncNiagaraCaptureSimCache : UCancellableAsyncAction {
	public static UClass StaticClass() {return default;}
	///<summary>FOnCaptureComplete</summary>
	public void FOnCaptureComplete(bool bSuccess) {}
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
	///<summary>Capture a simulation cache with customizable capture parameters.</summary>
	public static UAsyncNiagaraCaptureSimCache CaptureNiagaraSimCache(UNiagaraSimCache SimCache,FNiagaraSimCacheCreateParameters CreateParameters,UNiagaraComponent NiagaraComponent,FNiagaraSimCacheCaptureParameters CaptureParameters,UNiagaraSimCache OutSimCache) { return default; }
}
