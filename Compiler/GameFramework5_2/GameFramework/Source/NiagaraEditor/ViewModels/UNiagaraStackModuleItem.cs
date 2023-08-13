namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/Stack/NiagaraStackModuleItem.h")]
public partial class UNiagaraStackModuleItem : UNiagaraStackItem {
	public static UClass StaticClass() {return default;}
	///<summary>LinkedInputCollection</summary>
	public UNiagaraStackModuleItemLinkedInputCollection LinkedInputCollection;
	///<summary>InputCollection</summary>
	public UNiagaraStackFunctionInputCollection InputCollection;
	///<summary>OutputCollection</summary>
	public UNiagaraStackModuleItemOutputCollection OutputCollection;
}
