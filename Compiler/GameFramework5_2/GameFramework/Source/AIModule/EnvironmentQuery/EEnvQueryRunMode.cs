#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public enum EEnvQueryRunMode {
	SingleResult=0,
	RandomBest5Pct=1,
	RandomBest25Pct=2,
	AllMatching=3,
}
