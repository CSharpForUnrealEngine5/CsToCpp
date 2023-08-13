namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
[CppEnumInNamespace]
public enum EEnvQueryTrace {
	None=0,
	Navigation=1,
	GeometryByChannel=2,
	GeometryByProfile=3,
	NavigationOverLedges=4,
}
