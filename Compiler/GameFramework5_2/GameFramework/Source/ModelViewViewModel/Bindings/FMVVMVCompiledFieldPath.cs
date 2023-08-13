namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains the info to evaluate a path for a specific library.</summary>
[CppInclude("Bindings/MVVMCompiledBindingLibrary.h")]
public partial struct FMVVMVCompiledFieldPath {
	public short StartIndex;
	public short Num;
	public FGuid CompiledBindingLibraryId;
}
