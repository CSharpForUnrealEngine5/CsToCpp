namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/NiagaraSystemSelectionViewModel.h")]
public partial class UNiagaraSystemSelectionViewModel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>StackSelection</summary>
	public UNiagaraStackSelection StackSelection;
	///<summary>SelectionStackViewModel</summary>
	public UNiagaraStackViewModel SelectionStackViewModel;
}
