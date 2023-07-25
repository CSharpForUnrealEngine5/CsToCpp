#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlResponse.h")]
public partial struct FDescribeObjectResponse {
// DescribeObjectResponse
	public string Name;
	public UClass Class;
	public TArray<FRCPropertyDescription> Properties;
	public TArray<FRCFunctionDescription> Functions;
}
