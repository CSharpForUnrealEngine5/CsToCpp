#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/MVVMViewModelCollection.h")]
public partial class UMVVMViewModelCollectionObject : UObject {
// MVVMViewModelCollectionObject
	public  UMVVMViewModelBase FindViewModelInstance(FMVVMViewModelContext Context) { return default; }
	public  UMVVMViewModelBase FindFirstViewModelInstanceOfType(UClass ViewModelClass) { return default; }
	public  bool AddViewModelInstance(FMVVMViewModelContext Context,UMVVMViewModelBase ViewModel) { return default; }
	public  bool RemoveViewModel(FMVVMViewModelContext Context) { return default; }
	public  int RemoveAllViewModelInstance(UMVVMViewModelBase ViewModel) { return default; }
	public FMVVMViewModelCollection ViewModelCollection;
}
