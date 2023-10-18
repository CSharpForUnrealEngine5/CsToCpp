namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A base class that is used to refresh data that represents external data. Inherit from this class if you need more context data.</summary>
[CppInclude("ViewModels/HierarchyEditor/NiagaraHierarchyViewModelBase.h")]
public partial class UNiagaraHierarchyDataRefreshContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>IdentityToObjectMap</summary>
	public TMap<FNiagaraHierarchyIdentity,UObject> IdentityToObjectMap;
}
