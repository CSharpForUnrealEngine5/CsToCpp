namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Debug message emitted by ability tasks</summary>
[CppInclude("Abilities/GameplayAbilityTypes.h")]
public partial struct FAbilityTaskDebugMessage {
	public UGameplayTask FromTask;
	public string Message;
}
