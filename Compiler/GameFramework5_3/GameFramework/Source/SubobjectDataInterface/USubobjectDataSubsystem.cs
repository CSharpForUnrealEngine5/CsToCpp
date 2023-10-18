namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Subobject Data Subsystem will produce the reflected subobject data</summary>
[CppInclude("SubobjectDataSubsystem.h")]
public partial class USubobjectDataSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Gather all subobjects that the given Blueprint context has. Populates an array of</summary>
	public void K2_GatherSubobjectDataForBlueprint(UBlueprint Context,TArray<FSubobjectDataHandle> OutArray) {}
	///<summary>Gather all subobjects that the given actor instance has. Populates an array of</summary>
	public void K2_GatherSubobjectDataForInstance(AActor Context,TArray<FSubobjectDataHandle> OutArray) {}
	///<summary>Attempt to find the subobject data for a given handle. OutData will only</summary>
	public bool K2_FindSubobjectDataFromHandle(FSubobjectDataHandle Handle,FSubobjectData OutData) { return default; }
	///<summary>Attempt to find an existing handle for the given object.</summary>
	public FSubobjectDataHandle FindHandleForObject(FSubobjectDataHandle Context,UObject ObjectToFind,UBlueprint BPContext/*=nullptr*/) { return default; }
	///<summary>Creates a new C++ component from the specified class type</summary>
	public static UClass CreateNewCPPComponent(UClass ComponentClass,string NewClassPath,string NewClassName) { return default; }
	///<summary>Creates a new Blueprint component from the specified class type</summary>
	public static UClass CreateNewBPComponent(UClass ComponentClass,string NewClassPath,string NewClassName) { return default; }
	///<summary>Add a new subobject as a child to the given parent object</summary>
	public FSubobjectDataHandle AddNewSubobject(FAddNewSubobjectParams Params,FText FailReason) { return default; }
	///<summary>Attempts to delete the given array of subobjects from their context</summary>
	public int DeleteSubobjects(FSubobjectDataHandle ContextHandle,TArray<FSubobjectDataHandle> SubobjectsToDelete,UBlueprint BPContext/*=nullptr*/) { return default; }
	///<summary>Attempts to delete the given array of subobjects from their context</summary>
	public int K2_DeleteSubobjectsFromInstance(FSubobjectDataHandle ContextHandle,TArray<FSubobjectDataHandle> SubobjectsToDelete) { return default; }
	///<summary>Attempts to delete the given subobject from its blueprint context</summary>
	public int DeleteSubobject(FSubobjectDataHandle ContextHandle,FSubobjectDataHandle SubobjectToDelete,UBlueprint BPContext/*=nullptr*/) { return default; }
	///<summary>Attempts to delete the given subobject from its context</summary>
	public int K2_DeleteSubobjectFromInstance(FSubobjectDataHandle ContextHandle,FSubobjectDataHandle SubobjectToDelete) { return default; }
	///<summary>Attempts to rename the given subobject to the new name.</summary>
	public bool RenameSubobject(FSubobjectDataHandle Handle,FText InNewName) { return default; }
	///<summary>Attempts to change the subclass of a native component</summary>
	public bool ChangeSubobjectClass(FSubobjectDataHandle Handle,UClass NewClass) { return default; }
	///<summary>Attempts to reparent the given subobject to the new parent</summary>
	public bool ReparentSubobject(FReparentSubobjectParams Params,FSubobjectDataHandle ToReparentHandle) { return default; }
	///<summary>MakeNewSceneRoot</summary>
	public bool MakeNewSceneRoot(FSubobjectDataHandle Context,FSubobjectDataHandle NewSceneRoot,UBlueprint BPContext) { return default; }
	///<summary>Attempts to reparent all subobjects in the HandlesToMove array to the new parent handle.</summary>
	public bool ReparentSubobjects(FReparentSubobjectParams Params,TArray<FSubobjectDataHandle> HandlesToMove) { return default; }
	///<summary>Remove the child subobject from the owner</summary>
	public bool DetachSubobject(FSubobjectDataHandle OwnerHandle,FSubobjectDataHandle ChildToRemove) { return default; }
	///<summary>Add the given subobject to a new owner. This will remove the subobject from its previous</summary>
	public bool AttachSubobject(FSubobjectDataHandle OwnerHandle,FSubobjectDataHandle ChildToAddHandle) { return default; }
	///<summary>Returns true if the given new text is a valid option to rename the</summary>
	public bool IsValidRename(FSubobjectDataHandle Handle,FText InNewText,FText OutErrorMessage) { return default; }
	///<summary>Returns true if the given array of handles represents subobjects that</summary>
	public bool CanCopySubobjects(TArray<FSubobjectDataHandle> Handles) { return default; }
	///<summary>CopySubobjects</summary>
	public void CopySubobjects(TArray<FSubobjectDataHandle> Handles,UBlueprint BpContext) {}
	///<summary>CanPasteSubobjects</summary>
	public bool CanPasteSubobjects(FSubobjectDataHandle RootHandle,UBlueprint BPContext/*=nullptr*/) { return default; }
	///<summary>RenameSubobjectMemberVariable</summary>
	public static void RenameSubobjectMemberVariable(UBlueprint BPContext,FSubobjectDataHandle InHandle,FName NewName) {}
}
