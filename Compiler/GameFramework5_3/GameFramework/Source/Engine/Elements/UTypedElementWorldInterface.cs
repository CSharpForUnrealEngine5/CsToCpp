namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementWorldInterface.h")]
public partial class UTypedElementWorldInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Is this element considered a template within its world (eg, a CDO or archetype).</summary>
	public virtual bool IsTemplateElement(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Can this element actually be edited in the world?</summary>
	public virtual bool CanEditElement(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Get the owner level associated with this element, if any.</summary>
	public virtual ULevel GetOwnerLevel(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Get the owner world associated with this element, if any.</summary>
	public virtual UWorld GetOwnerWorld(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Get the bounds of this element, if any.</summary>
	public virtual bool GetBounds(FScriptTypedElementHandle InElementHandle,FBoxSphereBounds OutBounds) { return default; }
	///<summary>Can the given element be moved within the world?</summary>
	public virtual bool CanMoveElement(FScriptTypedElementHandle InElementHandle,ETypedElementWorldType InWorldType) { return default; }
	///<summary>Get the transform of this element within its owner world, if any.</summary>
	public virtual bool GetWorldTransform(FScriptTypedElementHandle InElementHandle,FTransform OutTransform) { return default; }
	///<summary>Attempt to set the transform of this element within its owner world.</summary>
	public virtual bool SetWorldTransform(FScriptTypedElementHandle InElementHandle,FTransform InTransform) { return default; }
	///<summary>Get the transform of this element relative to its parent, if any.</summary>
	public virtual bool GetRelativeTransform(FScriptTypedElementHandle InElementHandle,FTransform OutTransform) { return default; }
	///<summary>Attempt to set the transform of this element relative to its parent.</summary>
	public virtual bool SetRelativeTransform(FScriptTypedElementHandle InElementHandle,FTransform InTransform) { return default; }
	///<summary>Get the local space offset of this element that should be added to its pivot location, if any.</summary>
	public virtual bool GetPivotOffset(FScriptTypedElementHandle InElementHandle,FVector OutPivotOffset) { return default; }
	///<summary>Attempt to set the local space offset of this element that should be added to its pivot location.</summary>
	public virtual bool SetPivotOffset(FScriptTypedElementHandle InElementHandle,FVector InPivotOffset) { return default; }
	///<summary>Notify that this element is about to be moved.</summary>
	public virtual void NotifyMovementStarted(FScriptTypedElementHandle InElementHandle) {}
	///<summary>Notify that this element is currently being moved.</summary>
	public virtual void NotifyMovementOngoing(FScriptTypedElementHandle InElementHandle) {}
	///<summary>Notify that this element is done being moved.</summary>
	public virtual void NotifyMovementEnded(FScriptTypedElementHandle InElementHandle) {}
	///<summary>Can the given element be deleted?</summary>
	public virtual bool CanDeleteElement(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Delete the given element.</summary>
	public virtual bool DeleteElement(FScriptTypedElementHandle InElementHandle,UWorld InWorld,UTypedElementSelectionSet InSelectionSet,FTypedElementDeletionOptions InDeletionOptions) { return default; }
	///<summary>Can the given element be duplicated?</summary>
	public virtual bool CanDuplicateElement(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Duplicate the given element.</summary>
	public virtual FScriptTypedElementHandle DuplicateElement(FScriptTypedElementHandle InElementHandle,UWorld InWorld,FVector InLocationOffset) { return default; }
	///<summary>Can the element be promoted</summary>
	public virtual bool CanPromoteElement(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Promote an element when possible</summary>
	public virtual FScriptTypedElementHandle PromoteElement(FScriptTypedElementHandle InElementHandle,UWorld OverrideWorld/*=nullptr*/) { return default; }
}
