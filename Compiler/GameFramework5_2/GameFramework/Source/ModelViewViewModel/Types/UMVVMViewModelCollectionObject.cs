#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Types/MVVMViewModelCollection.h")]
public partial class UMVVMViewModelCollectionObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FindViewModelInstance</summary>
	public  UMVVMViewModelBase FindViewModelInstance(FMVVMViewModelContext Context) { return default; }
	///<summary>Finds a View Model of the given type.</summary>
	public  UMVVMViewModelBase FindFirstViewModelInstanceOfType(UClass ViewModelClass) { return default; }
	///<summary>AddViewModelInstance</summary>
	public  bool AddViewModelInstance(FMVVMViewModelContext Context,UMVVMViewModelBase ViewModel) { return default; }
	///<summary>RemoveViewModel</summary>
	public  bool RemoveViewModel(FMVVMViewModelContext Context) { return default; }
	///<summary>RemoveAllViewModelInstance</summary>
	public  int RemoveAllViewModelInstance(UMVVMViewModelBase ViewModel) { return default; }
	///<summary>ViewModelCollection</summary>
	public FMVVMViewModelCollection ViewModelCollection;
}
