namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of functions useful for generating trajectories based on the behavior of the UCharacterMovementComponent.</summary>
[CppInclude("CharacterMovementTrajectoryLibrary.h")]
public partial class UCharacterMovementTrajectoryLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Approximate the behavior of the UCharacterMovementComponent during ground locomotion.</summary>
	public static void StepCharacterMovementGroundPrediction(float InDeltaTime,FVector InVelocity,FVector InAcceleration,UCharacterMovementComponent InCharacterMovementComponent,FVector OutVelocity) {}
}
