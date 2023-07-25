#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AIBlueprintHelperLibrary.h")]
public partial class UAIBlueprintHelperLibrary : UBlueprintFunctionLibrary {
// AIBlueprintHelperLibrary
	public UObject CreateMoveToProxyObject(UObject WorldContextObject,UObject Pawn,FVector Destination,UObject TargetActor/*=NULL*/,float AcceptanceRadius/*=5.0f*/,bool bStopOnOverlap/*=false*/) { return default; }
	public void SendAIMessage(UObject Target,string Message,UObject MessageSource,bool bSuccess/*=true*/) {}
	public UObject SpawnAIFromClass(UObject WorldContextObject,UClass PawnClass,UObject BehaviorTree,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bNoCollisionFail/*=false*/,UObject Owner/*=nullptr*/) { return default; }
	public UObject GetAIController(UObject ControlledActor) { return default; }
	public UObject GetBlackboard(UObject Target) { return default; }
	public void LockAIResourcesWithAnimation(UObject AnimInstance,bool bLockMovement,bool LockAILogic) {}
	public void UnlockAIResourcesWithAnimation(UObject AnimInstance,bool bUnlockMovement,bool UnlockAILogic) {}
	public bool IsValidAILocation(FVector Location) { return default; }
	public bool IsValidAIDirection(FVector DirectionVector) { return default; }
	public bool IsValidAIRotation(FRotator Rotation) { return default; }
	public UObject GetCurrentPath(UObject Controller) { return default; }
	public TArray<FVector> GetCurrentPathPoints(UObject Controller) { return default; }
	public int GetCurrentPathIndex(UObject Controller) { return default; }
	public int GetNextNavLinkIndex(UObject Controller) { return default; }
	public void SimpleMoveToActor(UObject Controller,UObject Goal) {}
	public void SimpleMoveToLocation(UObject Controller,FVector Goal) {}
}
