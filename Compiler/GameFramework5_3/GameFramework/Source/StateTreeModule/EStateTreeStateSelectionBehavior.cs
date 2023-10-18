namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
public enum EStateTreeStateSelectionBehavior {
	None=0,
	TryEnterState=1,
	TrySelectChildrenInOrder=2,
	TryFollowTransitions=3,
}
