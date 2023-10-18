namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/MaterialXTestFunctions.h")]
public partial class UMaterialXTestFunctions : UImportTestFunctionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether the expected number of inputs are connected to the MX_StandardSurface material function</summary>
	public static FInterchangeTestFunctionResult CheckConnectedInputCount(UMaterialInterface MaterialInterface,int ExpectedNumber) { return default; }
	///<summary>Check whether a specific input of the MX_StandardSurface material function is connected or not</summary>
	public static FInterchangeTestFunctionResult CheckInputConnected(UMaterialInterface MaterialInterface,string InputName,bool bIsConnected) { return default; }
}
