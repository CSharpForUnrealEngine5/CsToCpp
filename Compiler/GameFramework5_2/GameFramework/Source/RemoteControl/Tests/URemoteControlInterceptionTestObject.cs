#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RemoteControlInterceptionTestData.h")]
public partial class URemoteControlInterceptionTestObject : UObject {
// RemoteControlInterceptionTestObject
	public FRemoteControlInterceptionTestStruct CustomStruct;
	public FRemoteControlInterceptionFunctionParamStruct FunctionParamStruct;
	public  FRemoteControlInterceptionFunctionParamStruct TestFunction(FRemoteControlInterceptionFunctionParamStruct InStruct,int InTestFactor) { return default; }
}
