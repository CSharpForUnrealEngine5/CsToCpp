#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Interfaces/IAudioGameplayCondition.h")]
public partial class UAudioGameplayCondition : UInterface {
	///<summary>Basic condition check</summary>
	public  bool ConditionMet() { return default; }
	///<summary>Allows testing a condition against a provided position.</summary>
	public  bool ConditionMet_Position(FVector Position) { return default; }
}
