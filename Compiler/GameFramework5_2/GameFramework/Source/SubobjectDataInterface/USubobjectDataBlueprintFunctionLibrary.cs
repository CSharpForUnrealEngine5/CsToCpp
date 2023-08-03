#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A function library with wrappers around the getter/setter functions for FSubobjectData</summary>
[CppInclude("SubobjectDataBlueprintFunctionLibrary.h")]
public partial class USubobjectDataBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>IsValid</summary>
	public static bool IsValid(FSubobjectData Data) { return default; }
	///<summary>IsHandleValid</summary>
	public static bool IsHandleValid(FSubobjectDataHandle DataHandle) { return default; }
	///<summary>GetData</summary>
	public static void GetData(FSubobjectDataHandle DataHandle,FSubobjectData OutData) {}
	///<summary>@return Get the handle for this subobject data</summary>
	public static void GetHandle(FSubobjectData Data,FSubobjectDataHandle OutHandle) {}
	///<summary>GetDisplayName</summary>
	public  string GetDisplayName(FSubobjectData Data) { return default; }
	///<summary>GetVariableName</summary>
	public static string GetVariableName(FSubobjectData Data) { return default; }
	///<summary>IsAttachedTo</summary>
	public static bool IsAttachedTo(FSubobjectData Data,FSubobjectDataHandle InHandle) { return default; }
	///<summary>@return Whether or not we can edit properties for this subobject</summary>
	public static bool CanEdit(FSubobjectData Data) { return default; }
	///<summary>@return Whether or not this object represents a subobject that can be deleted</summary>
	public static bool CanDelete(FSubobjectData Data) { return default; }
	///<summary>@return Whether or not this object represents a subobject that can be duplicated</summary>
	public static bool CanDuplicate(FSubobjectData Data) { return default; }
	///<summary>@return Whether or not this object represents a subobject that can be copied</summary>
	public static bool CanCopy(FSubobjectData Data) { return default; }
	///<summary>@return Whether or not this object represents a subobject that can</summary>
	public static bool CanReparent(FSubobjectData Data) { return default; }
	///<summary>CanRename</summary>
	public static bool CanRename(FSubobjectData Data) { return default; }
	///<summary>GetObject</summary>
	public static UObject GetObject(FSubobjectData Data,bool bEvenIfPendingKill/*=false*/) { return default; }
	///<summary>GetObjectForBlueprint</summary>
	public static UObject GetObjectForBlueprint(FSubobjectData Data,UBlueprint Blueprint) { return default; }
	///<summary>GetBlueprint</summary>
	public  UBlueprint GetBlueprint(FSubobjectData Data) { return default; }
	///<summary>IsInstancedComponent</summary>
	public static bool IsInstancedComponent(FSubobjectData Data) { return default; }
	///<summary>IsInstancedActor</summary>
	public static bool IsInstancedActor(FSubobjectData Data) { return default; }
	///<summary>IsNativeComponent</summary>
	public static bool IsNativeComponent(FSubobjectData Data) { return default; }
	///<summary>IsInheritedComponent</summary>
	public static bool IsInheritedComponent(FSubobjectData Data) { return default; }
	///<summary>IsSceneComponent</summary>
	public static bool IsSceneComponent(FSubobjectData Data) { return default; }
	///<summary>IsRootComponent</summary>
	public static bool IsRootComponent(FSubobjectData Data) { return default; }
	///<summary>IsDefaultSceneRoot</summary>
	public static bool IsDefaultSceneRoot(FSubobjectData Data) { return default; }
	///<summary>Returns true if this subobject is a component.</summary>
	public static bool IsComponent(FSubobjectData Data) { return default; }
	///<summary>IsChildActor</summary>
	public static bool IsChildActor(FSubobjectData Data) { return default; }
	///<summary>IsRootActor</summary>
	public static bool IsRootActor(FSubobjectData Data) { return default; }
	///<summary>IsActor</summary>
	public static bool IsActor(FSubobjectData Data) { return default; }
}
