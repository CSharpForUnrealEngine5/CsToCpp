#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/Stack/NiagaraStackEntry.h")]
public partial class UNiagaraStackEntry : UObject {
// NiagaraStackEntry
	public UNiagaraStackEditorData StackEditorData;
	public TArray<UNiagaraStackEntry> Children;
	public TArray<UNiagaraStackErrorItem> ErrorChildren;
}
