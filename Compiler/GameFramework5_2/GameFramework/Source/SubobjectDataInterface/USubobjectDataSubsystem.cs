#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubobjectDataSubsystem.h")]
///<summary>The Subobject Data Subsystem will produce the reflected subobject data</summary>
public partial class USubobjectDataSubsystem : UEngineSubsystem {
// SubobjectDataSubsystem
	public void K2_GatherSubobjectDataForBlueprint(UObject Context,TArray<FSubobjectDataHandle> OutArray) {}
	public void K2_GatherSubobjectDataForInstance(UObject Context,TArray<FSubobjectDataHandle> OutArray) {}
	public bool K2_FindSubobjectDataFromHandle(FSubobjectDataHandle Handle,FSubobjectData OutData) { return default; }
	public FSubobjectDataHandle FindHandleForObject(FSubobjectDataHandle Context,UObject ObjectToFind,UObject BPContext/*=nullptr*/) { return default; }
	public UClass CreateNewCPPComponent(UClass ComponentClass,string NewClassPath,string NewClassName) { return default; }
	public UClass CreateNewBPComponent(UClass ComponentClass,string NewClassPath,string NewClassName) { return default; }
	public FSubobjectDataHandle AddNewSubobject(FAddNewSubobjectParams Params,string FailReason) { return default; }
	public int DeleteSubobjects(FSubobjectDataHandle ContextHandle,TArray<FSubobjectDataHandle> SubobjectsToDelete,UObject BPContext/*=nullptr*/) { return default; }
	public int K2_DeleteSubobjectsFromInstance(FSubobjectDataHandle ContextHandle,TArray<FSubobjectDataHandle> SubobjectsToDelete) { return default; }
	public int DeleteSubobject(FSubobjectDataHandle ContextHandle,FSubobjectDataHandle SubobjectToDelete,UObject BPContext/*=nullptr*/) { return default; }
	public int K2_DeleteSubobjectFromInstance(FSubobjectDataHandle ContextHandle,FSubobjectDataHandle SubobjectToDelete) { return default; }
	public bool RenameSubobject(FSubobjectDataHandle Handle,string InNewName) { return default; }
	public bool ChangeSubobjectClass(FSubobjectDataHandle Handle,UClass NewClass) { return default; }
	public bool ReparentSubobject(FReparentSubobjectParams Params,FSubobjectDataHandle ToReparentHandle) { return default; }
	public bool MakeNewSceneRoot(FSubobjectDataHandle Context,FSubobjectDataHandle NewSceneRoot,UObject BPContext) { return default; }
	public bool ReparentSubobjects(FReparentSubobjectParams Params,TArray<FSubobjectDataHandle> HandlesToMove) { return default; }
	public bool DetachSubobject(FSubobjectDataHandle OwnerHandle,FSubobjectDataHandle ChildToRemove) { return default; }
	public bool AttachSubobject(FSubobjectDataHandle OwnerHandle,FSubobjectDataHandle ChildToAddHandle) { return default; }
	public bool IsValidRename(FSubobjectDataHandle Handle,string InNewText,string OutErrorMessage) { return default; }
	public bool CanCopySubobjects(TArray<FSubobjectDataHandle> Handles) { return default; }
	public void CopySubobjects(TArray<FSubobjectDataHandle> Handles,UObject BpContext) {}
	public bool CanPasteSubobjects(FSubobjectDataHandle RootHandle,UObject BPContext/*=nullptr*/) { return default; }
	public void RenameSubobjectMemberVariable(UObject BPContext,FSubobjectDataHandle InHandle,string NewName) {}
}
