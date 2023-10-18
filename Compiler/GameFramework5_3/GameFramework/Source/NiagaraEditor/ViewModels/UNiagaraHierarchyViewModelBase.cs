namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/HierarchyEditor/NiagaraHierarchyViewModelBase.h")]
public partial class UNiagaraHierarchyViewModelBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>HierarchyRoot</summary>
	public UNiagaraHierarchyRoot HierarchyRoot;
	///<summary>RefreshContext</summary>
	public UNiagaraHierarchyDataRefreshContext RefreshContext;
}
