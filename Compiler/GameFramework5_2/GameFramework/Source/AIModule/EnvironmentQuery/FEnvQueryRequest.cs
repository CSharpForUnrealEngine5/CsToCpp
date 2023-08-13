namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>wrapper for easy query execution</summary>
[CppInclude("EnvironmentQuery/EnvQueryManager.h")]
public partial struct FEnvQueryRequest {
	public UEnvQuery QueryTemplate;
	public UObject Owner;
	public UWorld World;
}
