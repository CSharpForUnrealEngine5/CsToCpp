namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintViewBinding.h")]
public partial struct FMVVMBlueprintViewBinding {
	public FMVVMBlueprintPropertyPath ViewModelPath;
	public FMVVMBlueprintPropertyPath WidgetPath;
	public EMVVMBindingMode BindingType;
	public bool bOverrideExecutionMode;
	public EMVVMExecutionMode OverrideExecutionMode;
	public FMVVMBlueprintViewConversionPath Conversion;
	public TArray<FText> Errors;
	public FGuid BindingId;
	public bool bEnabled;
	public bool bCompile;
}
