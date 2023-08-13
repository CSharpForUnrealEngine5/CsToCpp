namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/HierarchyEditor/NiagaraHierarchyViewModelBase.h")]
public partial class UNiagaraHierarchyCategory : UNiagaraHierarchyItemBase {
	public static UClass StaticClass() {return default;}
	///<summary>Category</summary>
	public string Category;
	///<summary>The tooltip used when the user is hovering this category</summary>
	public FText Tooltip;
	///<summary>Section</summary>
	public UNiagaraHierarchySection Section;
}
