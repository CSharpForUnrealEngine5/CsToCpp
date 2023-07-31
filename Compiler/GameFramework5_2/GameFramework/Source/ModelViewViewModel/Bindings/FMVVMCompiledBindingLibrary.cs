#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of all the compiled bindings.</summary>
[CppInclude("Bindings/MVVMCompiledBindingLibrary.h")]
public partial struct FMVVMCompiledBindingLibrary {
	public TArray<UFunction> LoadedFunctions;
	public TArray<FMVVMCompiledLoadedPropertyOrFunctionIndex> FieldPaths;
	public FGuid CompiledBindingLibraryId;
	public TArray<FMVVMVCompiledFields> CompiledFields;
	public TArray<string> CompiledFieldNames;
}
