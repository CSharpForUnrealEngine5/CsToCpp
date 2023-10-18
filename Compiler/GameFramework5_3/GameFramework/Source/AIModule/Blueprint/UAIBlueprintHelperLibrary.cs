namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AIBlueprintHelperLibrary.h")]
public partial class UAIBlueprintHelperLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>CreateMoveToProxyObject</summary>
	public static UAIAsyncTaskBlueprintProxy CreateMoveToProxyObject(UObject WorldContextObject,APawn Pawn,FVector Destination,AActor TargetActor/*=NULL*/,float AcceptanceRadius/*=5.0f*/,bool bStopOnOverlap/*=false*/) { return default; }
	///<summary>SendAIMessage</summary>
	public static void SendAIMessage(APawn Target,FName Message,UObject MessageSource,bool bSuccess/*=true*/) {}
	///<summary>Spawns AI agent of a given class. The PawnClass needs to have AIController</summary>
	public static APawn SpawnAIFromClass(UObject WorldContextObject,UClass PawnClass,UBehaviorTree BehaviorTree,FVector Location,FRotator Rotation/*=FRotator.ZeroRotator*/,bool bNoCollisionFail/*=false*/,AActor Owner/*=nullptr*/) { return default; }
	///<summary>The way it works exactly is if the actor passed in is a pawn, then the function retrieves</summary>
	public static AAIController GetAIController(AActor ControlledActor) { return default; }
	///<summary>GetBlackboard</summary>
	public static UBlackboardComponent GetBlackboard(AActor Target) { return default; }
	///<summary>locks indicated AI resources of animated pawn</summary>
	public static void LockAIResourcesWithAnimation(UAnimInstance AnimInstance,bool bLockMovement,bool LockAILogic) {}
	///<summary>unlocks indicated AI resources of animated pawn. Will unlock only animation-locked resources</summary>
	public static void UnlockAIResourcesWithAnimation(UAnimInstance AnimInstance,bool bUnlockMovement,bool UnlockAILogic) {}
	///<summary>IsValidAILocation</summary>
	public static bool IsValidAILocation(FVector Location) { return default; }
	///<summary>IsValidAIDirection</summary>
	public static bool IsValidAIDirection(FVector DirectionVector) { return default; }
	///<summary>IsValidAIRotation</summary>
	public static bool IsValidAIRotation(FRotator Rotation) { return default; }
	///<summary>Returns a NEW UOBJECT that is a COPY of navigation path given controller is currently using.</summary>
	public static UNavigationPath GetCurrentPath(AController Controller) { return default; }
	///<summary>Returns an array of navigation path points given controller is currently using.</summary>
	public static TArray<FVector> GetCurrentPathPoints(AController Controller) { return default; }
	///<summary>Return the path index the given controller is currently at. Returns INDEX_NONE if no path.</summary>
	public static int GetCurrentPathIndex(AController Controller) { return default; }
	///<summary>Return the path index of the next nav link for the current path of the given controller. Returns INDEX_NONE if no path or no incoming nav link.</summary>
	public static int GetNextNavLinkIndex(AController Controller) { return default; }
	///<summary>SimpleMoveToActor</summary>
	public static void SimpleMoveToActor(AController Controller,AActor Goal) {}
	///<summary>SimpleMoveToLocation</summary>
	public static void SimpleMoveToLocation(AController Controller,FVector Goal) {}
}
