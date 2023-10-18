namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/HierarchyEditor/NiagaraHierarchyViewModelBase.h")]
public partial class UNiagaraHierarchySection : UNiagaraHierarchyItemBase {
	public static UClass StaticClass() {return default;}
	///<summary>Section</summary>
	public FName Section;
	///<summary>The tooltip used when the user is hovering this section</summary>
	public FText Tooltip;
}
