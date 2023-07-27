#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PawnMovementComponent.h")]
///<summary>PawnMovementComponent can be used to update movement for an associated Pawn.</summary>
public partial class UPawnMovementComponent : UNavMovementComponent {
// PawnMovementComponent
	public  void AddInputVector(FVector WorldVector,bool bForce/*=false*/) {}
	public  FVector GetPendingInputVector() { return default; }
	public  FVector GetLastInputVector() { return default; }
	public  FVector ConsumeInputVector() { return default; }
	public  bool IsMoveInputIgnored() { return default; }
	public  APawn GetPawnOwner() { return default; }
	public APawn PawnOwner;
}
