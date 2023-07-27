#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCacheFunctionLibrary.h")]
public partial class UAsyncNiagaraCaptureSimCache : UBlueprintAsyncActionBase {
// AsyncNiagaraCaptureSimCache
	public  void FOnCaptureComplete(bool bSuccess) {}
	public UNiagaraSimCache CaptureSimCache;
	public UNiagaraComponent CaptureComponent;
	public FOnCaptureComplete CaptureComplete;
	public static UAsyncNiagaraCaptureSimCache CaptureNiagaraSimCacheMultiFrame(UNiagaraSimCache SimCache,FNiagaraSimCacheCreateParameters CreateParameters,UNiagaraComponent NiagaraComponent,UNiagaraSimCache OutSimCache,int NumFrames/*=16*/,int CaptureRate/*=1*/,bool bAdvanceSimulation/*=false*/,float AdvanceDeltaTime/*=0.01666f*/) { return default; }
	public static UAsyncNiagaraCaptureSimCache CaptureNiagaraSimCacheUntilComplete(UNiagaraSimCache SimCache,FNiagaraSimCacheCreateParameters CreateParameters,UNiagaraComponent NiagaraComponent,UNiagaraSimCache OutSimCache,int CaptureRate/*=1*/,bool bAdvanceSimulation/*=false*/,float AdvanceDeltaTime/*=0.01666f*/) { return default; }
}
