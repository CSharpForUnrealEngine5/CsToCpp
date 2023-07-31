#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Status describing current run status of a State Tree.</summary>
public enum EStateTreeRunStatus {
	Running=0,
	Failed=1,
	Succeeded=2,
	Unset=3,
}
