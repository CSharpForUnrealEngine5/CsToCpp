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
	public UMVVMViewModelContextResolver Resolver;
	public bool bCreateSetterFunction;
	public bool bOptional;
	public bool bCanRename;
	public bool bCanEdit;
	public bool bCanRemove;
}
