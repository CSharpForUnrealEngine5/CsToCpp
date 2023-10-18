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
