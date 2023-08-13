namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FDescribeObjectResponse {
	public string Name;
	public UClass Class;
	public TArray<FRCPropertyDescription> Properties;
	public TArray<FRCFunctionDescription> Functions;
}
