namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Transition priority. When multiple transitions trigger at the same time, the first transition of highest priority is selected.</summary>
public enum EStateTreeTransitionPriority {
	None=0,
	Normal=1,
	Medium=2,
	High=3,
	Critical=4,
}
