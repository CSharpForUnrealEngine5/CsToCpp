#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Transitions behavior.</summary>
public enum EStateTreeTransitionType {
	None=0,
	Succeeded=1,
	Failed=2,
	GotoState=3,
	NextState=4,
	NotSet=5,
}
