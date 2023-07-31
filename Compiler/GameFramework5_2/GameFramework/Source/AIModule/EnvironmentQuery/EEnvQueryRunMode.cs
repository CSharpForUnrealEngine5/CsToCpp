#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
[CppEnumInNamespace]
public enum EEnvQueryRunMode {
	SingleResult=0,
	RandomBest5Pct=1,
	RandomBest25Pct=2,
	AllMatching=3,
}
