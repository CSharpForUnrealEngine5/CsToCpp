#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMEditorSubsystem.h")]
public partial class UMVVMEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>RequestView</summary>
	public  UMVVMBlueprintView RequestView(UWidgetBlueprint WidgetBlueprint) { return default; }
	///<summary>GetView</summary>
	public  UMVVMBlueprintView GetView(UWidgetBlueprint WidgetBlueprint) { return default; }
	///<summary>AddViewModel</summary>
	public  string AddViewModel(UWidgetBlueprint WidgetBlueprint,UClass ViewModel) { return default; }
	///<summary>RemoveViewModel</summary>
	public  void RemoveViewModel(UWidgetBlueprint WidgetBlueprint,string ViewModel) {}
	///<summary>VerifyViewModelRename</summary>
	public  bool VerifyViewModelRename(UWidgetBlueprint WidgetBlueprint,string ViewModel,string NewViewModel,string OutError) { return default; }
	///<summary>RenameViewModel</summary>
	public  bool RenameViewModel(UWidgetBlueprint WidgetBlueprint,string ViewModel,string NewViewModel,string OutError) { return default; }
	///<summary>AddBinding</summary>
	public  FMVVMBlueprintViewBinding AddBinding(UWidgetBlueprint WidgetBlueprint) { return default; }
	///<summary>RemoveBinding</summary>
	public  void RemoveBinding(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintViewBinding Binding) {}
	///<summary>GetChildViewModels</summary>
	public  TArray<FMVVMAvailableBinding> GetChildViewModels(UClass Class,UClass Accessor) { return default; }
	///<summary>IsValidConversionFunction</summary>
	public  bool IsValidConversionFunction(UFunction Function,FMVVMBlueprintPropertyPath Source,FMVVMBlueprintPropertyPath Destination) { return default; }
	///<summary>IsSimpleConversionFunction</summary>
	public  bool IsSimpleConversionFunction(UFunction Function) { return default; }
	///<summary>GetConversionFunctionGraph</summary>
	public  UEdGraph GetConversionFunctionGraph(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	///<summary>GetConversionFunction</summary>
	public  UFunction GetConversionFunction(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	///<summary>GetConversionFunctionNode</summary>
	public  UK2Node_CallFunction GetConversionFunctionNode(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	///<summary>GetAvailableConversionFunctions</summary>
	public  TArray<UFunction> GetAvailableConversionFunctions(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintPropertyPath Source,FMVVMBlueprintPropertyPath Destination) { return default; }
}
