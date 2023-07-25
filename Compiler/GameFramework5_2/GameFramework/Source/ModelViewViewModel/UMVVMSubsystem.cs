#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMSubsystem.h")]
public partial class UMVVMSubsystem : UEngineSubsystem {
// MVVMSubsystem
	public UObject K2_GetViewFromUserWidget(UObject UserWidget) { return default; }
	public bool DoesWidgetTreeContainedWidget(UObject WidgetTree,UObject ViewWidget) { return default; }
	public TArray<FMVVMAvailableBinding> K2_GetAvailableBindings(UClass Class,UClass Accessor) { return default; }
	public FMVVMAvailableBinding K2_GetAvailableBinding(UClass Class,FMVVMBindingName BindingName,UClass Accessor) { return default; }
	public UObject GetGlobalViewModelCollection() { return default; }
	public UMVVMViewModelCollectionObject GlobalViewModelCollection;
}
