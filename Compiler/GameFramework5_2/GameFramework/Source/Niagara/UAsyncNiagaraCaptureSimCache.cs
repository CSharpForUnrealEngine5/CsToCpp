#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCacheFunctionLibrary.h")]
public partial class UAsyncNiagaraCaptureSimCache : UBlueprintAsyncActionBase {
// AsyncNiagaraCaptureSimCache
	public void FOnCaptureComplete(bool bSuccess) {}
	public UNiagaraSimCache CaptureSimCache;
	public UNiagaraComponent CaptureComponent;
	public FOnCaptureComplete CaptureComplete;
	public UObject CaptureNiagaraSimCacheMultiFrame(UObject SimCache,FNiagaraSimCacheCreateParameters CreateParameters,UObject NiagaraComponent,UObject OutSimCache,int NumFrames/*=16*/,int CaptureRate/*=1*/,bool bAdvanceSimulation/*=false*/,float AdvanceDeltaTime/*=0.01666f*/) { return default; }
	public UObject CaptureNiagaraSimCacheUntilComplete(UObject SimCache,FNiagaraSimCacheCreateParameters CreateParameters,UObject NiagaraComponent,UObject OutSimCache,int CaptureRate/*=1*/,bool bAdvanceSimulation/*=false*/,float AdvanceDeltaTime/*=0.01666f*/) { return default; }
}
