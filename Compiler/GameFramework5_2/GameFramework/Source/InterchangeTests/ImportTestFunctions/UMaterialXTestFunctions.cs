#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/MaterialXTestFunctions.h")]
public partial class UMaterialXTestFunctions : UImportTestFunctionsBase {
	///<summary>Check whether the expected number of inputs are connected to the MX_StandardSurface material function</summary>
	public static FInterchangeTestFunctionResult CheckConnectedInputCount(UMaterialInterface MaterialInterface,int ExpectedNumber) { return default; }
	///<summary>Check whether a specific input of the MX_StandardSurface material function is connected or not</summary>
	public static FInterchangeTestFunctionResult CheckInputConnected(UMaterialInterface MaterialInterface,string InputName,bool bIsConnected) { return default; }
}
