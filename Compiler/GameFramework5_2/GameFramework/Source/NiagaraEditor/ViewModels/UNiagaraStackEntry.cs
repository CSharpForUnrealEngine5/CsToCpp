#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/Stack/NiagaraStackEntry.h")]
public partial class UNiagaraStackEntry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>StackEditorData</summary>
	public UNiagaraStackEditorData StackEditorData;
	///<summary>Children</summary>
	public TArray<UNiagaraStackEntry> Children;
	///<summary>ErrorChildren</summary>
	public TArray<UNiagaraStackErrorItem> ErrorChildren;
}
