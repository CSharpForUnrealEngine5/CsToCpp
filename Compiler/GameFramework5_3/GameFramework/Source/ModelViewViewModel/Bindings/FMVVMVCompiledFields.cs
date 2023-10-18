namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The info to fetch a list of FProperty or UFunction from a Class that will be needed by bindings.</summary>
[CppInclude("Bindings/MVVMCompiledBindingLibrary.h")]
public partial struct FMVVMVCompiledFields {
	public UStruct ClassOrScriptStruct;
	public short LibraryStartIndex;
	public short NumberOfProperties;
	public short NumberOfFunctions;
	public short NumberOfFieldIds;
}
