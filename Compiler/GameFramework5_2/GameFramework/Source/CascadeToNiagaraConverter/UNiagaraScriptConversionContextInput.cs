#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
///<summary>Wrapper for setting the value on a parameter of a UNiagaraScript, applied through a UNiagaraScriptConversionContext.</summary>
public partial class UNiagaraScriptConversionContextInput : UObject {
// NiagaraScriptConversionContextInput
	public void Init(UObject InClipboardFunctionInput,ENiagaraScriptInputType InInputType,FNiagaraTypeDefinition InTypeDefinition) {}
	public UNiagaraClipboardFunctionInput ClipboardFunctionInput;
	public ENiagaraScriptInputType InputType;
	public FNiagaraTypeDefinition TypeDefinition;
}
