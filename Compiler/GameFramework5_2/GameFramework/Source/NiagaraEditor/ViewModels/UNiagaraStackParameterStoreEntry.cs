namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a single module input in the module stack view model.</summary>
[CppInclude("ViewModels/Stack/NiagaraStackParameterStoreEntry.h")]
public partial class UNiagaraStackParameterStoreEntry : UNiagaraStackItemContent {
	public static UClass StaticClass() {return default;}
	///<summary>The stack entry for displaying the value object.</summary>
	public UNiagaraStackObject ValueObjectEntry;
}
