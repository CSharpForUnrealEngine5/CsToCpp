#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintView.h")]
public partial class UMVVMBlueprintView : UObject {
// MVVMBlueprintView
	public TArray<UEdGraph> TemporaryGraph;
	public TArray<FMVVMBlueprintViewBinding> Bindings;
	public TArray<FMVVMBlueprintViewModelContext> AvailableViewModels;
}
