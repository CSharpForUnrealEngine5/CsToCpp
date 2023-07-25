#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMEditorSubsystem.h")]
public partial class UMVVMEditorSubsystem : UEditorSubsystem {
// MVVMEditorSubsystem
	public UObject RequestView(UObject WidgetBlueprint) { return default; }
	public UObject GetView(UObject WidgetBlueprint) { return default; }
	public string AddViewModel(UObject WidgetBlueprint,UClass ViewModel) { return default; }
	public void RemoveViewModel(UObject WidgetBlueprint,string ViewModel) {}
	public bool VerifyViewModelRename(UObject WidgetBlueprint,string ViewModel,string NewViewModel,string OutError) { return default; }
	public bool RenameViewModel(UObject WidgetBlueprint,string ViewModel,string NewViewModel,string OutError) { return default; }
	public FMVVMBlueprintViewBinding AddBinding(UObject WidgetBlueprint) { return default; }
	public void RemoveBinding(UObject WidgetBlueprint,FMVVMBlueprintViewBinding Binding) {}
	public TArray<FMVVMAvailableBinding> GetChildViewModels(UClass Class,UClass Accessor) { return default; }
	public bool IsValidConversionFunction(UObject Function,FMVVMBlueprintPropertyPath Source,FMVVMBlueprintPropertyPath Destination) { return default; }
	public bool IsSimpleConversionFunction(UObject Function) { return default; }
	public UObject GetConversionFunctionGraph(UObject WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	public UObject GetConversionFunction(UObject WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	public UObject GetConversionFunctionNode(UObject WidgetBlueprint,FMVVMBlueprintViewBinding Binding,bool bSourceToDestination) { return default; }
	public TArray<UObject> GetAvailableConversionFunctions(UObject WidgetBlueprint,FMVVMBlueprintPropertyPath Source,FMVVMBlueprintPropertyPath Destination) { return default; }
}
