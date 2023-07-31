#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains a single combination to execute a binding for a specific library.</summary>
[CppInclude("Bindings/MVVMCompiledBindingLibrary.h")]
public partial struct FMVVMVCompiledBinding {
	public FMVVMVCompiledFieldPath SourceFieldPath;
	public FMVVMVCompiledFieldPath DestinationFieldPath;
	public FMVVMVCompiledFieldPath ConversionFunctionFieldPath;
	public FGuid CompiledBindingLibraryId;
}
