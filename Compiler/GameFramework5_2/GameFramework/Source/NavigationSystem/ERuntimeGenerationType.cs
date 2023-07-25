#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationData.h")]
///<summary>Supported options for runtime navigation data generation</summary>
public enum ERuntimeGenerationType {
	Static=0,
	DynamicModifiersOnly=1,
	Dynamic=2,
	LegacyGeneration=3,
}
