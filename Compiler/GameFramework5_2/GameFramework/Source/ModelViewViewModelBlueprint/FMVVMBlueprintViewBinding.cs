#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintViewBinding.h")]
public partial struct FMVVMBlueprintViewBinding {
// MVVMBlueprintViewBinding
	public FMVVMBlueprintPropertyPath ViewModelPath;
	public FMVVMBlueprintPropertyPath WidgetPath;
	public EMVVMBindingMode BindingType;
	public bool bOverrideExecutionMode;
	public EMVVMExecutionMode OverrideExecutionMode;
	public FMVVMBlueprintViewConversionPath Conversion;
	public TArray<string> Errors;
	public FGuid BindingId;
	public bool bEnabled;
	public bool bCompile;
}
