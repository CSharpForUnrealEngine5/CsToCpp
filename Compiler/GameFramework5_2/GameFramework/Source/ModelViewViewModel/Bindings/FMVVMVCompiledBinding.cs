#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Bindings/MVVMCompiledBindingLibrary.h")]
///<summary>Contains a single combination to execute a binding for a specific library.</summary>
public partial struct FMVVMVCompiledBinding {
// MVVMVCompiledBinding
	public FMVVMVCompiledFieldPath SourceFieldPath;
	public FMVVMVCompiledFieldPath DestinationFieldPath;
	public FMVVMVCompiledFieldPath ConversionFunctionFieldPath;
	public FGuid CompiledBindingLibraryId;
}
