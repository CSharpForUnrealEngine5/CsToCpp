#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>State change type. Passed to EnterState() and ExitState() to indicate how the state change affects the state and Evaluator or Task is on.</summary>
public enum EStateTreeStateChangeType {
	None=0,
	Changed=1,
	Sustained=2,
}
