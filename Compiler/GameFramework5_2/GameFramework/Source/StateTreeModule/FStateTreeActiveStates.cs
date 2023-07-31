#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an array of active states in a State Tree.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeActiveStates {
	public FStateTreeStateHandle States;
	public byte NumStates;
}
