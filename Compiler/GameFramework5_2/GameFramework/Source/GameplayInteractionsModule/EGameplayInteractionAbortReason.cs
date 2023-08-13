namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayInteractionsTypes.h")]
///<summary>Reason why the interaction is ended prematurely.</summary>
public enum EGameplayInteractionAbortReason {
	Unset=0,
	ExternalAbort=1,
	InternalAbort=2,
}
