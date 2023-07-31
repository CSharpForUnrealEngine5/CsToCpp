#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCacheFunctionLibrary.h")]
public partial class UNiagaraSimCacheFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>Captures the simulations current frame data into the SimCache.</summary>
	public static bool CaptureNiagaraSimCacheImmediate(UNiagaraSimCache SimCache,FNiagaraSimCacheCreateParameters CreateParameters,UNiagaraComponent NiagaraComponent,UNiagaraSimCache OutSimCache,bool bAdvanceSimulation/*=false*/,float AdvanceDeltaTime/*=0.01666f*/) { return default; }
	///<summary>Captures the simulation cache object that can be captured into using the various API calls.</summary>
	public static UNiagaraSimCache CreateNiagaraSimCache(UObject WorldContextObject) { return default; }
}
