namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannel_Islands.h")]
public partial class UNiagaraDataChannelHandler_Islands : UNiagaraDataChannelHandler {
	public static UClass StaticClass() {return default;}
	///<summary>All currently active Islands for this channel.</summary>
	public TArray<int> ActiveIslands;
	///<summary>All currently free Islands for this channel.</summary>
	public TArray<int> FreeIslands;
	///<summary>Pool of all islands.</summary>
	public TArray<FNDCIsland> IslandPool;
}
