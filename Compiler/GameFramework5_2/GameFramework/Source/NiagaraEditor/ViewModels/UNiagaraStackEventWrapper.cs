#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a wrapper class used for the details customization in the stack, since the event script properties were moved from the emitter object into the version data struct</summary>
[CppInclude("ViewModels/Stack/NiagaraStackEventScriptItemGroup.h")]
public partial class UNiagaraStackEventWrapper : UObject {
	///<summary>EventHandlerScriptProps</summary>
	public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps;
}
