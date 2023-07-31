#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>wrapper for easy query execution</summary>
[CppInclude("EnvironmentQuery/EnvQueryManager.h")]
public partial struct FEnvQueryRequest {
	public UEnvQuery QueryTemplate;
	public UObject Owner;
	public UWorld World;
}
