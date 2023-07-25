#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimCharacterMovementLibrary.h")]
///<summary>Library of common techniques for driving character locomotion animations.</summary>
public partial class UAnimCharacterMovementLibrary : UBlueprintFunctionLibrary {
// AnimCharacterMovementLibrary
	public FVector PredictGroundMovementStopLocation(FVector Velocity,bool bUseSeparateBrakingFriction,float BrakingFriction,float GroundFriction,float BrakingFrictionFactor,float BrakingDecelerationWalking) { return default; }
	public FVector PredictGroundMovementPivotLocation(FVector Acceleration,FVector Velocity,float GroundFriction) { return default; }
}
