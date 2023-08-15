namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintViewModelContext.h")]
public partial struct FMVVMBlueprintViewModelContext {
	public FGuid ViewModelContextId;
	public UClass NotifyFieldValueClass;
	public UClass ViewModelClass_DEPRECATED;
	public FText OverrideDisplayName_DEPRECATED;
	public FName ViewModelName;
	public EMVVMBlueprintViewModelContextCreationType CreationType;
	public FName GlobalViewModelIdentifier;
	public string ViewModelPropertyPath;
	public bool bCreateSetterFunction;
	public bool bOptional;
}
