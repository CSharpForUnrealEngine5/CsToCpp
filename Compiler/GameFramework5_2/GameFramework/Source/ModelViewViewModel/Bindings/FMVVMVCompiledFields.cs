#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Bindings/MVVMCompiledBindingLibrary.h")]
///<summary>The info to fetch a list of FProperty or UFunction from a Class that will be needed by bindings.</summary>
public partial struct FMVVMVCompiledFields {
// MVVMVCompiledFields
	public UStruct ClassOrScriptStruct;
	public short LibraryStartIndex;
	public short NumberOfProperties;
	public short NumberOfFunctions;
	public short NumberOfFieldIds;
}
