#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintView.h")]
public partial class UMVVMBlueprintView : UObject {
	///<summary>Use during compilation to clean the automatically generated graph.</summary>
	public TArray<UEdGraph> TemporaryGraph;
	///<summary>Bindings</summary>
	public TArray<FMVVMBlueprintViewBinding> Bindings;
	///<summary>AvailableViewModels</summary>
	public TArray<FMVVMBlueprintViewModelContext> AvailableViewModels;
}
