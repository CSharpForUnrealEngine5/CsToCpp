#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeOp.h")]
public partial class UNiagaraNodeOp : UNiagaraNodeWithDynamicPins {
	public static UClass StaticClass() {return default;}
	///<summary>Name of operation</summary>
	public string OpName;
	///<summary>AddedPins</summary>
	public TArray<FAddedPinData> AddedPins;
	///<summary>bAllStatic</summary>
	public bool bAllStatic;
}
