#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/Stack/NiagaraStackEventScriptItemGroup.h")]
///<summary>This is a wrapper class used for the details customization in the stack, since the event script properties were moved from the emitter object into the version data struct</summary>
public partial class UNiagaraStackEventWrapper : UObject {
// NiagaraStackEventWrapper
	public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps;
}
