#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubobjectDataBlueprintFunctionLibrary.h")]
///<summary>A function library with wrappers around the getter/setter functions for FSubobjectData</summary>
public partial class USubobjectDataBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// SubobjectDataBlueprintFunctionLibrary
	public bool IsValid(FSubobjectData Data) { return default; }
	public bool IsHandleValid(FSubobjectDataHandle DataHandle) { return default; }
	public void GetData(FSubobjectDataHandle DataHandle,FSubobjectData OutData) {}
	public void GetHandle(FSubobjectData Data,FSubobjectDataHandle OutHandle) {}
	public string GetDisplayName(FSubobjectData Data) { return default; }
	public string GetVariableName(FSubobjectData Data) { return default; }
	public bool IsAttachedTo(FSubobjectData Data,FSubobjectDataHandle InHandle) { return default; }
	public bool CanEdit(FSubobjectData Data) { return default; }
	public bool CanDelete(FSubobjectData Data) { return default; }
	public bool CanDuplicate(FSubobjectData Data) { return default; }
	public bool CanCopy(FSubobjectData Data) { return default; }
	public bool CanReparent(FSubobjectData Data) { return default; }
	public bool CanRename(FSubobjectData Data) { return default; }
	public UObject GetObject(FSubobjectData Data,bool bEvenIfPendingKill/*=false*/) { return default; }
	public UObject GetObjectForBlueprint(FSubobjectData Data,UObject Blueprint) { return default; }
	public UObject GetBlueprint(FSubobjectData Data) { return default; }
	public bool IsInstancedComponent(FSubobjectData Data) { return default; }
	public bool IsInstancedActor(FSubobjectData Data) { return default; }
	public bool IsNativeComponent(FSubobjectData Data) { return default; }
	public bool IsInheritedComponent(FSubobjectData Data) { return default; }
	public bool IsSceneComponent(FSubobjectData Data) { return default; }
	public bool IsRootComponent(FSubobjectData Data) { return default; }
	public bool IsDefaultSceneRoot(FSubobjectData Data) { return default; }
	public bool IsComponent(FSubobjectData Data) { return default; }
	public bool IsChildActor(FSubobjectData Data) { return default; }
	public bool IsRootActor(FSubobjectData Data) { return default; }
	public bool IsActor(FSubobjectData Data) { return default; }
}
