namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMGameSubsystem.h")]
public partial class UMVVMGameSubsystem : UGameInstanceSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>GetViewModelCollection</summary>
	public UMVVMViewModelCollectionObject GetViewModelCollection() { return default; }
	///<summary>ViewModelCollection</summary>
	public UMVVMViewModelCollectionObject ViewModelCollection;
}
