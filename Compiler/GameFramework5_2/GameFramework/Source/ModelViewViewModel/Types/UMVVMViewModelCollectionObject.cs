#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/MVVMViewModelCollection.h")]
public partial class UMVVMViewModelCollectionObject : UObject {
// MVVMViewModelCollectionObject
	public UObject FindViewModelInstance(FMVVMViewModelContext Context) { return default; }
	public UObject FindFirstViewModelInstanceOfType(UClass ViewModelClass) { return default; }
	public bool AddViewModelInstance(FMVVMViewModelContext Context,UObject ViewModel) { return default; }
	public bool RemoveViewModel(FMVVMViewModelContext Context) { return default; }
	public int RemoveAllViewModelInstance(UObject ViewModel) { return default; }
	public FMVVMViewModelCollection ViewModelCollection;
}
