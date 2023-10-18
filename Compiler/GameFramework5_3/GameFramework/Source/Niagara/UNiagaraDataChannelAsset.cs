namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper asset class for UNiagaraDataChannel which is instanced.</summary>
[CppInclude("NiagaraDataChannelPublic.h")]
public partial class UNiagaraDataChannelAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DataChannel</summary>
	public UNiagaraDataChannel DataChannel;
	///<summary>When changing data channel types we cache the old channel and attempt to copy over any common properties from one to the other.</summary>
	public UNiagaraDataChannel CachedPreChangeDataChannel;
}
