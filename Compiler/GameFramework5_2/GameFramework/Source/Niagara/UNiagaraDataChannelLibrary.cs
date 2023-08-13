namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A C++ and Blueprint accessible library of utility functions for accessing Niagara DataChannel</summary>
[CppInclude("NiagaraDataChannel.h")]
public partial class UNiagaraDataChannelLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetNiagaraDataChannel</summary>
	public static UNiagaraDataChannelHandler GetNiagaraDataChannel(UObject WorldContextObject,string Channel) { return default; }
}
