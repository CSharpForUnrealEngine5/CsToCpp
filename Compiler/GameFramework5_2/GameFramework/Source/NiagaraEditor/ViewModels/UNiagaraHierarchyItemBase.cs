#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/HierarchyEditor/NiagaraHierarchyViewModelBase.h")]
public partial class UNiagaraHierarchyItemBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Children</summary>
	public TArray<UNiagaraHierarchyItemBase> Children;
	///<summary>Identity</summary>
	public FNiagaraHierarchyIdentity Identity;
	///<summary>An optional guid; can be used if hierarchy items represent outside items</summary>
	public FGuid Guid_DEPRECATED;
	///<summary>bFinalized</summary>
	public bool bFinalized;
}
