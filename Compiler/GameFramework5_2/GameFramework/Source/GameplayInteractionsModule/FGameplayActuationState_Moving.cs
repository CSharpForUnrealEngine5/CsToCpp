#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes movement state.</summary>
[CppInclude("GameplayActuationState.h")]
public partial struct FGameplayActuationState_Moving {
	public FVector3f HeadingDirection;
	public FGameplayActuationPredictedLocation Prediction;
}
