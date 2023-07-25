#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MVVMPropertyPath.h")]
///<summary>Base path to properties for MVVM view models and widgets.</summary>
public partial struct FMVVMBlueprintPropertyPath {
// MVVMBlueprintPropertyPath
	public TArray<FMVVMBlueprintFieldPath> Paths;
	public string WidgetName;
	public FGuid ContextId;
	public FMemberReference BindingReference;
	public EBindingKind BindingKind;
}
