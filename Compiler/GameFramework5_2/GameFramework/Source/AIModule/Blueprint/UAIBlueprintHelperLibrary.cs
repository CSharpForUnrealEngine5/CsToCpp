#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AIBlueprintHelperLibrary.h")]
public partial class UAIBlueprintHelperLibrary : UBlueprintFunctionLibrary {
// AIBlueprintHelperLibrary
	public static UAIAsyncTaskBlueprintProxy CreateMoveToProxyObject(UObject WorldContextObject,APawn Pawn,FVector Destination,AActor TargetActor/*=NULL*/,float AcceptanceRadius/*=5.0f*/,bool bStopOnOverlap/*=false*/) { return default; }
	public static void SendAIMessage(APawn Target,string Message,UObject MessageSource,bool bSuccess/*=true*/) {}
	public static APawn SpawnAIFromClass(UObject WorldContextObject,UClass PawnClass,UBehaviorTree BehaviorTree,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bNoCollisionFail/*=false*/,AActor Owner/*=nullptr*/) { return default; }
	public static AAIController GetAIController(AActor ControlledActor) { return default; }
	public static UBlackboardComponent GetBlackboard(AActor Target) { return default; }
	public static void LockAIResourcesWithAnimation(UAnimInstance AnimInstance,bool bLockMovement,bool LockAILogic) {}
	public static void UnlockAIResourcesWithAnimation(UAnimInstance AnimInstance,bool bUnlockMovement,bool UnlockAILogic) {}
	public static bool IsValidAILocation(FVector Location) { return default; }
	public static bool IsValidAIDirection(FVector DirectionVector) { return default; }
	public static bool IsValidAIRotation(FRotator Rotation) { return default; }
	public static UNavigationPath GetCurrentPath(AController Controller) { return default; }
	public static TArray<FVector> GetCurrentPathPoints(AController Controller) { return default; }
	public static int GetCurrentPathIndex(AController Controller) { return default; }
	public static int GetNextNavLinkIndex(AController Controller) { return default; }
	public static void SimpleMoveToActor(AController Controller,AActor Goal) {}
	public static void SimpleMoveToLocation(AController Controller,FVector Goal) {}
}
