#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/HierarchyEditor/NiagaraHierarchyViewModelBase.h")]
public partial class UNiagaraHierarchyItemBase : UObject {
// NiagaraHierarchyItemBase
	public TArray<UNiagaraHierarchyItemBase> Children;
	public FNiagaraHierarchyIdentity Identity;
	public FGuid Guid_DEPRECATED;
	public bool bFinalized;
}
