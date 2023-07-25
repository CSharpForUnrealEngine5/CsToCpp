#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryManager.h")]
///<summary>wrapper for easy query execution</summary>
public partial struct FEnvQueryRequest {
// EnvQueryRequest
	public UEnvQuery QueryTemplate;
	public UObject Owner;
	public UWorld World;
}
