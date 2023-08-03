#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Shared between every instances of the same View class.</summary>
[CppInclude("View/MVVMViewClass.h")]
public partial class UMVVMViewClass : UWidgetBlueprintGeneratedClassExtension {
	public static UClass StaticClass() {return default;}
	///<summary>Data to retrieve/create the sources (could be viewmodel, widget, ...).</summary>
	public TArray<FMVVMViewClass_SourceCreator> SourceCreators;
	///<summary>CompiledBindings</summary>
	public TArray<FMVVMViewClass_CompiledBinding> CompiledBindings;
	///<summary>All the bindings shared between all the View instance.</summary>
	public FMVVMCompiledBindingLibrary BindingLibrary;
}
