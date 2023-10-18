namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A node that allows a user to get multiple values from a parameter map.</summary>
[CppInclude("NiagaraNodeParameterMapGet.h")]
public partial class UNiagaraNodeParameterMapGet : UNiagaraNodeParameterMapBase {
	public static UClass StaticClass() {return default;}
	///<summary>PinOutputToPinDefaultPersistentId</summary>
	public TMap<FGuid,FGuid> PinOutputToPinDefaultPersistentId;
}
