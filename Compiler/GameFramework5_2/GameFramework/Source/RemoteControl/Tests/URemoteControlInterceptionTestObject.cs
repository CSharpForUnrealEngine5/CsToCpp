#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RemoteControlInterceptionTestData.h")]
public partial class URemoteControlInterceptionTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CustomStruct</summary>
	public FRemoteControlInterceptionTestStruct CustomStruct;
	///<summary>FunctionParamStruct</summary>
	public FRemoteControlInterceptionFunctionParamStruct FunctionParamStruct;
	///<summary>TestFunction</summary>
	public  FRemoteControlInterceptionFunctionParamStruct TestFunction(FRemoteControlInterceptionFunctionParamStruct InStruct,int InTestFactor) { return default; }
}
