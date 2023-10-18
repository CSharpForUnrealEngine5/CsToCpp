namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeImportTestStepBase.h")]
public partial class UInterchangeImportTestStepBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>An array of results to check against</summary>
	public TArray<FInterchangeTestFunction> Tests;
}
