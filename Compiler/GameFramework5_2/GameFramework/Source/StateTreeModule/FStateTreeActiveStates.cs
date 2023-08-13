namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes an array of active states in a State Tree.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeActiveStates {
	public FStateTreeStateHandle States;
	public byte NumStates;
}
