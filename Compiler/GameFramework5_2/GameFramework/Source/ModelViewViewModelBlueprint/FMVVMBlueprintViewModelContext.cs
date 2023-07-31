#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMBlueprintViewModelContext.h")]
public partial struct FMVVMBlueprintViewModelContext {
	public FGuid ViewModelContextId;
	public UClass NotifyFieldValueClass;
	public UClass ViewModelClass_DEPRECATED;
	public string OverrideDisplayName_DEPRECATED;
	public string ViewModelName;
	public EMVVMBlueprintViewModelContextCreationType CreationType;
	public string GlobalViewModelIdentifier;
	public string ViewModelPropertyPath;
	public bool bCreateSetterFunction;
	public bool bOptional;
}
