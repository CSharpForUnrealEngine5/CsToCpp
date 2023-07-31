#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
[CppEnumInNamespace]
public enum EEnvQueryStatus {
	Processing=0,
	Success=1,
	Failed=2,
	Aborted=3,
	OwnerLost=4,
	MissingParam=5,
}
