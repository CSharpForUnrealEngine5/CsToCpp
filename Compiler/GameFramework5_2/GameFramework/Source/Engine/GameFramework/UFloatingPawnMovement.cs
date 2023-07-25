#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/FloatingPawnMovement.h")]
///<summary>FloatingPawnMovement is a movement component that provides simple movement for any Pawn class.</summary>
public partial class UFloatingPawnMovement : UPawnMovementComponent {
// FloatingPawnMovement
	public float MaxSpeed;
	public float Acceleration;
	public float Deceleration;
	public float TurningBoost;
	public bool bPositionCorrected;
}
