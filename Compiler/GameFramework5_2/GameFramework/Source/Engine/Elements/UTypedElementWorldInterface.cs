#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementWorldInterface.h")]
public partial class UTypedElementWorldInterface : UInterface {
// TypedElementWorldInterface
	public  bool IsTemplateElement(FScriptTypedElementHandle InElementHandle) { return default; }
	public  bool CanEditElement(FScriptTypedElementHandle InElementHandle) { return default; }
	public  ULevel GetOwnerLevel(FScriptTypedElementHandle InElementHandle) { return default; }
	public  UWorld GetOwnerWorld(FScriptTypedElementHandle InElementHandle) { return default; }
	public  bool GetBounds(FScriptTypedElementHandle InElementHandle,FBoxSphereBounds OutBounds) { return default; }
	public  bool CanMoveElement(FScriptTypedElementHandle InElementHandle,ETypedElementWorldType InWorldType) { return default; }
	public  bool GetWorldTransform(FScriptTypedElementHandle InElementHandle,FTransform OutTransform) { return default; }
	public  bool SetWorldTransform(FScriptTypedElementHandle InElementHandle,FTransform InTransform) { return default; }
	public  bool GetRelativeTransform(FScriptTypedElementHandle InElementHandle,FTransform OutTransform) { return default; }
	public  bool SetRelativeTransform(FScriptTypedElementHandle InElementHandle,FTransform InTransform) { return default; }
	public  bool GetPivotOffset(FScriptTypedElementHandle InElementHandle,FVector OutPivotOffset) { return default; }
	public  bool SetPivotOffset(FScriptTypedElementHandle InElementHandle,FVector InPivotOffset) { return default; }
	public  void NotifyMovementStarted(FScriptTypedElementHandle InElementHandle) {}
	public  void NotifyMovementOngoing(FScriptTypedElementHandle InElementHandle) {}
	public  void NotifyMovementEnded(FScriptTypedElementHandle InElementHandle) {}
	public  bool CanDeleteElement(FScriptTypedElementHandle InElementHandle) { return default; }
	public  bool DeleteElement(FScriptTypedElementHandle InElementHandle,UWorld InWorld,UTypedElementSelectionSet InSelectionSet,FTypedElementDeletionOptions InDeletionOptions) { return default; }
	public  bool CanDuplicateElement(FScriptTypedElementHandle InElementHandle) { return default; }
	public  FScriptTypedElementHandle DuplicateElement(FScriptTypedElementHandle InElementHandle,UWorld InWorld,FVector InLocationOffset) { return default; }
	public  bool CanPromoteElement(FScriptTypedElementHandle InElementHandle) { return default; }
	public  FScriptTypedElementHandle PromoteElement(FScriptTypedElementHandle InElementHandle,UWorld OverrideWorld/*=nullptr*/) { return default; }
}
