#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMSubsystem.h")]
public partial class UMVVMSubsystem : UEngineSubsystem {
// MVVMSubsystem
	public  UMVVMView K2_GetViewFromUserWidget(UUserWidget UserWidget) { return default; }
	public  bool DoesWidgetTreeContainedWidget(UWidgetTree WidgetTree,UWidget ViewWidget) { return default; }
	public  TArray<FMVVMAvailableBinding> K2_GetAvailableBindings(UClass Class,UClass Accessor) { return default; }
	public  FMVVMAvailableBinding K2_GetAvailableBinding(UClass Class,FMVVMBindingName BindingName,UClass Accessor) { return default; }
	public  UMVVMViewModelCollectionObject GetGlobalViewModelCollection() { return default; }
	public UMVVMViewModelCollectionObject GlobalViewModelCollection;
}
