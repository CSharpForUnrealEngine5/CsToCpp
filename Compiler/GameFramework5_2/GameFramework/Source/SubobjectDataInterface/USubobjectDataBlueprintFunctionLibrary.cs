#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SubobjectDataBlueprintFunctionLibrary.h")]
///<summary>A function library with wrappers around the getter/setter functions for FSubobjectData</summary>
public partial class USubobjectDataBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// SubobjectDataBlueprintFunctionLibrary
	public static bool IsValid(FSubobjectData Data) { return default; }
	public static bool IsHandleValid(FSubobjectDataHandle DataHandle) { return default; }
	public static void GetData(FSubobjectDataHandle DataHandle,FSubobjectData OutData) {}
	public static void GetHandle(FSubobjectData Data,FSubobjectDataHandle OutHandle) {}
	public  string GetDisplayName(FSubobjectData Data) { return default; }
	public static string GetVariableName(FSubobjectData Data) { return default; }
	public static bool IsAttachedTo(FSubobjectData Data,FSubobjectDataHandle InHandle) { return default; }
	public static bool CanEdit(FSubobjectData Data) { return default; }
	public static bool CanDelete(FSubobjectData Data) { return default; }
	public static bool CanDuplicate(FSubobjectData Data) { return default; }
	public static bool CanCopy(FSubobjectData Data) { return default; }
	public static bool CanReparent(FSubobjectData Data) { return default; }
	public static bool CanRename(FSubobjectData Data) { return default; }
	public static UObject GetObject(FSubobjectData Data,bool bEvenIfPendingKill/*=false*/) { return default; }
	public static UObject GetObjectForBlueprint(FSubobjectData Data,UBlueprint Blueprint) { return default; }
	public  UBlueprint GetBlueprint(FSubobjectData Data) { return default; }
	public static bool IsInstancedComponent(FSubobjectData Data) { return default; }
	public static bool IsInstancedActor(FSubobjectData Data) { return default; }
	public static bool IsNativeComponent(FSubobjectData Data) { return default; }
	public static bool IsInheritedComponent(FSubobjectData Data) { return default; }
	public static bool IsSceneComponent(FSubobjectData Data) { return default; }
	public static bool IsRootComponent(FSubobjectData Data) { return default; }
	public static bool IsDefaultSceneRoot(FSubobjectData Data) { return default; }
	public static bool IsComponent(FSubobjectData Data) { return default; }
	public static bool IsChildActor(FSubobjectData Data) { return default; }
	public static bool IsRootActor(FSubobjectData Data) { return default; }
	public static bool IsActor(FSubobjectData Data) { return default; }
}
