#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset class defining a set of data channels that can be used for communications between Niagara Emitters and Systems.</summary>
[CppInclude("NiagaraDataChannelDefinitions.h")]
public partial class UNiagaraDataChannelDefinitions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>UObject Interface END</summary>
	public TArray<UNiagaraDataChannel> DataChannels;
}
