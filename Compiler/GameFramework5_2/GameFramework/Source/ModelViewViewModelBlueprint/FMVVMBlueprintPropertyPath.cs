#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base path to properties for MVVM view models and widgets.</summary>
[CppInclude("MVVMPropertyPath.h")]
public partial struct FMVVMBlueprintPropertyPath {
	public TArray<FMVVMBlueprintFieldPath> Paths;
	public string WidgetName;
	public FGuid ContextId;
	public FMemberReference BindingReference;
	public EBindingKind BindingKind;
}
