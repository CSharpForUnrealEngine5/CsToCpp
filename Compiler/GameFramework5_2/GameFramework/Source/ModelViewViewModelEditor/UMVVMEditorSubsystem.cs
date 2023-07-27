#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMEditorSubsystem.h")]
public partial class UMVVMEditorSubsystem : UEditorSubsystem {
// MVVMEditorSubsystem
	public  UMVVMBlueprintView RequestView(UWidgetBlueprint WidgetBlueprint) { return default; }
	public  UMVVMBlueprintView GetView(UWidgetBlueprint WidgetBlueprint) { return default; }
	public  string AddViewModel(UWidgetBlueprint WidgetBlueprint,UClass ViewModel) { return default; }
	public  void RemoveViewModel(UWidgetBlueprint WidgetBlueprint,string ViewModel) {}
	public  bool VerifyViewModelRename(UWidgetBlueprint WidgetBlueprint,string ViewModel,string NewViewModel,string OutError) { return default; }
	public  bool RenameViewModel(UWidgetBlueprint WidgetBlueprint,string ViewModel,string NewViewModel,string OutError) { return default; }
	public  FMVVMBlueprintViewBinding AddBinding(UWidgetBlueprint WidgetBlueprint) { return default; }
	public  void RemoveBinding(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintViewBinding Binding) {}
	public  TArray<FMVVMAvailableBinding> GetChildViewModels(UClass Class,UClass Accessor) { return default; }
	public  bool IsValidConversionFunction(UFunction Function,FMVVMBlueprintPropertyPath Source,FMVVMBlueprintPropertyPath Destination) { return default; }
	public  bool IsSimpleConversionFunction(UFunction Function) { return default; }
	public  UEdGraph GetConversionFunctionGraph(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	public  UFunction GetConversionFunction(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	public  UK2Node_CallFunction GetConversionFunctionNode(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	public  TArray<UFunction> GetAvailableConversionFunctions(UWidgetBlueprint WidgetBlueprint,FMVVMBlueprintPropertyPath Source,FMVVMBlueprintPropertyPath Destination) { return default; }
}
