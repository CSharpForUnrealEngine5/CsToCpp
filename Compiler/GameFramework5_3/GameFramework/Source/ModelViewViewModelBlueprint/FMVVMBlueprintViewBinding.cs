namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintViewBinding.h")]
public partial struct FMVVMBlueprintViewBinding {
	public FMVVMBlueprintPropertyPath SourcePath;
	public FMVVMBlueprintPropertyPath DestinationPath;
	public EMVVMBindingMode BindingType;
	public bool bOverrideExecutionMode;
	public EMVVMExecutionMode OverrideExecutionMode;
	public FMVVMBlueprintViewConversionPath Conversion;
	public FGuid BindingId;
	public bool bEnabled;
	public bool bCompile;
}
