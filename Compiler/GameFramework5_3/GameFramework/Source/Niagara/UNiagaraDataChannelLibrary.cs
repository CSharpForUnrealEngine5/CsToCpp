namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A C++ and Blueprint accessible library of utility functions for accessing Niagara DataChannel</summary>
[CppInclude("NiagaraDataChannel.h")]
public partial class UNiagaraDataChannelLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetNiagaraDataChannel</summary>
	public static UNiagaraDataChannelHandler GetNiagaraDataChannel(UObject WorldContextObject,UNiagaraDataChannelAsset Channel) { return default; }
	///<summary>Initializes and returns the Niagara Data Channel writer to write N elements to the given data channel.</summary>
	public static UNiagaraDataChannelWriter WriteToNiagaraDataChannel(UObject WorldContextObject,UNiagaraDataChannelAsset Channel,FNiagaraDataChannelSearchParameters SearchParams,int Count,bool bVisibleToGame,bool bVisibleToCPU,bool bVisibleToGPU) { return default; }
	///<summary>Initializes and returns the Niagara Data Channel reader for the given data channel.</summary>
	public static UNiagaraDataChannelReader ReadFromNiagaraDataChannel(UObject WorldContextObject,UNiagaraDataChannelAsset Channel,FNiagaraDataChannelSearchParameters SearchParams,bool bReadPreviousFrame) { return default; }
}
