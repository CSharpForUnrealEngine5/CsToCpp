namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/HierarchyEditor/NiagaraSummaryViewViewModel.h")]
public partial class UNiagaraHierarchyModuleInput : UNiagaraHierarchyItem {
	public static UClass StaticClass() {return default;}
	///<summary>If specified, will override how this input is presented in the stack.</summary>
	public FText DisplayNameOverride;
	///<summary>If specified, will override how the tooltip of this input in the stack.</summary>
	public FText TooltipOverride;
}
