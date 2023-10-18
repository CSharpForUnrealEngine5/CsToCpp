namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains a single combination to execute a binding for a specific library.</summary>
[CppInclude("Bindings/MVVMCompiledBindingLibrary.h")]
public partial struct FMVVMVCompiledBinding {
	public FMVVMVCompiledFieldPath SourceFieldPath;
	public FMVVMVCompiledFieldPath DestinationFieldPath;
	public FMVVMVCompiledFieldPath ConversionFunctionFieldPath;
	public byte Flags;
	public FGuid CompiledBindingLibraryId;
}
