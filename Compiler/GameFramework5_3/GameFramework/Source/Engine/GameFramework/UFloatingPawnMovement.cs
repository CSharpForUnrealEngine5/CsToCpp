namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FloatingPawnMovement is a movement component that provides simple movement for any Pawn class.</summary>
[CppInclude("GameFramework/FloatingPawnMovement.h")]
public partial class UFloatingPawnMovement : UPawnMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Maximum velocity magnitude allowed for the controlled Pawn.</summary>
	public float MaxSpeed;
	///<summary>Acceleration applied by input (rate of change of velocity)</summary>
	public float Acceleration;
	///<summary>Deceleration applied when there is no input (rate of change of velocity)</summary>
	public float Deceleration;
	///<summary>Setting affecting extra force applied when changing direction, making turns have less drift and become more responsive.</summary>
	public float TurningBoost;
	///<summary>Set to true when a position correction is applied. Used to avoid recalculating velocity when this occurs.</summary>
	public bool bPositionCorrected;
}
