namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base path to properties for MVVM view models and widgets.</summary>
[CppInclude("MVVMPropertyPath.h")]
public partial struct FMVVMBlueprintPropertyPath {
	public TArray<FMVVMBlueprintFieldPath> Paths;
	public FName WidgetName;
	public FGuid ContextId;
	public FMemberReference BindingReference;
	public EBindingKind BindingKind;
}
