namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintView.h")]
public partial class UMVVMBlueprintView : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Use during compilation to clean the automatically generated graph.</summary>
	public TArray<UEdGraph> TemporaryGraph;
	///<summary>Bindings</summary>
	public TArray<FMVVMBlueprintViewBinding> Bindings;
	///<summary>AvailableViewModels</summary>
	public TArray<FMVVMBlueprintViewModelContext> AvailableViewModels;
}
