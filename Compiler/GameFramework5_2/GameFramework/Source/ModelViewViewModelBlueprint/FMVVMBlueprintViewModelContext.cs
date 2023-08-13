namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintViewModelContext.h")]
public partial struct FMVVMBlueprintViewModelContext {
	public FGuid ViewModelContextId;
	public UClass NotifyFieldValueClass;
	public UClass ViewModelClass_DEPRECATED;
	public FText OverrideDisplayName_DEPRECATED;
	public string ViewModelName;
	public EMVVMBlueprintViewModelContextCreationType CreationType;
	public string GlobalViewModelIdentifier;
	public string ViewModelPropertyPath;
	public bool bCreateSetterFunction;
	public bool bOptional;
}
