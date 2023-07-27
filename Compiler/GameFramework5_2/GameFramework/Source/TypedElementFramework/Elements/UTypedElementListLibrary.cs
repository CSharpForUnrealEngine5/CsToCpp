#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementListLibrary.h")]
public partial class UTypedElementListLibrary : UObject {
// TypedElementListLibrary
	public static FScriptTypedElementListProxy CreateScriptElementList(UTypedElementRegistry Registry) { return default; }
	public static FScriptTypedElementListProxy Clone(FScriptTypedElementListProxy ElementList) { return default; }
	public static FScriptTypedElementHandle GetElementHandleAt(FScriptTypedElementListProxy ElementList,int Index) { return default; }
	public static UObject GetElementInterface(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle,UClass BaseInterfaceType) { return default; }
	public static bool HasElements(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType/*=nullptr*/) { return default; }
	public static int CountElements(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType/*=nullptr*/) { return default; }
	public static bool HasElementsOfType(FScriptTypedElementListProxy ElementList,string ElementTypeName) { return default; }
	public static int CountElementsOfType(FScriptTypedElementListProxy ElementList,string ElementTypeName) { return default; }
	public static TArray<FScriptTypedElementHandle> GetElementHandles(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType) { return default; }
	public static bool IsValidIndex(FScriptTypedElementListProxy ElementList,int Index) { return default; }
	public static int Num(FScriptTypedElementListProxy ElementList) { return default; }
	public static void Shrink(FScriptTypedElementListProxy ElementList) {}
	public static void Reserve(FScriptTypedElementListProxy ElementList,int Size) {}
	public static void Empty(FScriptTypedElementListProxy ElementList,int Slack/*=0*/) {}
	public static void Reset(FScriptTypedElementListProxy ElementList) {}
	public static bool Contains(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
	public static bool Add(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
	public static void Append(FScriptTypedElementListProxy ElementList,TArray<FScriptTypedElementHandle> ElementHandles) {}
	public static void AppendList(FScriptTypedElementListProxy ElementList,FScriptTypedElementListProxy OtherElementList) {}
	public static bool Remove(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
}
