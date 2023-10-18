namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Library of common techniques for driving character locomotion animations.</summary>
[CppInclude("AnimCharacterMovementLibrary.h")]
public partial class UAnimCharacterMovementLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Predict where the character will stop based on its current movement properties and parameters from the movement component.</summary>
	public static FVector PredictGroundMovementStopLocation(FVector Velocity,bool bUseSeparateBrakingFriction,float BrakingFriction,float GroundFriction,float BrakingFrictionFactor,float BrakingDecelerationWalking) { return default; }
	///<summary>Predict where the character will change direction during a pivot based on its current movement properties and parameters from the movement component.</summary>
	public static FVector PredictGroundMovementPivotLocation(FVector Acceleration,FVector Velocity,float GroundFriction) { return default; }
}
