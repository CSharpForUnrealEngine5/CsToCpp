namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeOp.h")]
public partial class UNiagaraNodeOp : UNiagaraNodeWithDynamicPins {
	public static UClass StaticClass() {return default;}
	///<summary>Name of operation</summary>
	public FName OpName;
	///<summary>AddedPins</summary>
	public TArray<FAddedPinData> AddedPins;
	///<summary>bAllStatic</summary>
	public bool bAllStatic;
}
