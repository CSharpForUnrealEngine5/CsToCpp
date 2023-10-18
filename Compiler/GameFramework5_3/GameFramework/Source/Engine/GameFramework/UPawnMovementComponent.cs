namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PawnMovementComponent can be used to update movement for an associated Pawn.</summary>
[CppInclude("GameFramework/PawnMovementComponent.h")]
public partial class UPawnMovementComponent : UNavMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Adds the given vector to the accumulated input in world space. Input vectors are usually between 0 and 1 in magnitude.</summary>
	public virtual void AddInputVector(FVector WorldVector,bool bForce/*=false*/) {}
	///<summary>Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it.</summary>
	public FVector GetPendingInputVector() { return default; }
	///<summary>Return the last input vector in world space that was processed by ConsumeInputVector(), which is usually done by the Pawn or PawnMovementComponent.</summary>
	public FVector GetLastInputVector() { return default; }
	///<summary>Returns the pending input vector and resets it to zero.</summary>
	public virtual FVector ConsumeInputVector() { return default; }
	///<summary>Helper to see if move input is ignored. If there is no Pawn or UpdatedComponent, returns true, otherwise defers to the Pawn&#39;s implementation of IsMoveInputIgnored().</summary>
	public virtual bool IsMoveInputIgnored() { return default; }
	///<summary>Return the Pawn that owns UpdatedComponent.</summary>
	public APawn GetPawnOwner() { return default; }
	///<summary>Pawn that owns this component.</summary>
	public APawn PawnOwner;
	///<summary>Send the physics command to execute to the server</summary>
	public void ServerAsyncPhysicsStateAction(UPrimitiveComponent ActionComponent,FName BoneName,FAsyncPhysicsTimestamp Timestamp,EPhysicsStateAction ActionType,FVector ActionDatas,FVector ActionPosition) {}
	///<summary>Dispatch back the physics command onto all the clients</summary>
	public void MulticastAsyncPhysicsStateAction(UPrimitiveComponent ActionComponent,FName BoneName,FAsyncPhysicsTimestamp Timestamp,EPhysicsStateAction ActionType,FVector ActionDatas,FVector ActionPosition) {}
}
