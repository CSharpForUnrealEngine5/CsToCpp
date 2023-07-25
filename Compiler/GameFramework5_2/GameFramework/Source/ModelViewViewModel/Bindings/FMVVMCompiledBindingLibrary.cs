#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Bindings/MVVMCompiledBindingLibrary.h")]
///<summary>Library of all the compiled bindings.</summary>
public partial struct FMVVMCompiledBindingLibrary {
// MVVMCompiledBindingLibrary
	public TArray<UFunction> LoadedFunctions;
	public TArray<FMVVMCompiledLoadedPropertyOrFunctionIndex> FieldPaths;
	public FGuid CompiledBindingLibraryId;
	public TArray<FMVVMVCompiledFields> CompiledFields;
	public TArray<string> CompiledFieldNames;
}
