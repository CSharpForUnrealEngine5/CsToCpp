namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMSubsystem.h")]
public partial class UMVVMSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>K2_GetViewFromUserWidget</summary>
	public UMVVMView K2_GetViewFromUserWidget(UUserWidget UserWidget) { return default; }
	///<summary>DoesWidgetTreeContainedWidget</summary>
	public bool DoesWidgetTreeContainedWidget(UWidgetTree WidgetTree,UWidget ViewWidget) { return default; }
	///<summary>@return The list of all the AvailableBindings that are available for the Class.</summary>
	public TArray<FMVVMAvailableBinding> K2_GetAvailableBindings(UClass Class,UClass Accessor) { return default; }
	///<summary>@return The AvailableBinding from a BindingName.</summary>
	public FMVVMAvailableBinding K2_GetAvailableBinding(UClass Class,FMVVMBindingName BindingName,UClass Accessor) { return default; }
	///<summary>GetGlobalViewModelCollection</summary>
	public UMVVMViewModelCollectionObject GetGlobalViewModelCollection() { return default; }
	///<summary>GlobalViewModelCollection</summary>
	public UMVVMViewModelCollectionObject GlobalViewModelCollection;
}
