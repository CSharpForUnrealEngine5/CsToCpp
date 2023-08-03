#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper for setting the value on a parameter of a UNiagaraScript, applied through a UNiagaraScriptConversionContext.</summary>
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial class UNiagaraScriptConversionContextInput : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Init</summary>
	public  void Init(UNiagaraClipboardFunctionInput InClipboardFunctionInput,ENiagaraScriptInputType InInputType,FNiagaraTypeDefinition InTypeDefinition) {}
	///<summary>ClipboardFunctionInput</summary>
	public UNiagaraClipboardFunctionInput ClipboardFunctionInput;
	///<summary>InputType</summary>
	public ENiagaraScriptInputType InputType;
	///<summary>TypeDefinition</summary>
	public FNiagaraTypeDefinition TypeDefinition;
}
