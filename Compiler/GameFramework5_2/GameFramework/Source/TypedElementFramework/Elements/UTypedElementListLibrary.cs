#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementListLibrary.h")]
public partial class UTypedElementListLibrary : UObject {
// TypedElementListLibrary
	public FScriptTypedElementListProxy CreateScriptElementList(UObject Registry) { return default; }
	public FScriptTypedElementListProxy Clone(FScriptTypedElementListProxy ElementList) { return default; }
	public FScriptTypedElementHandle GetElementHandleAt(FScriptTypedElementListProxy ElementList,int Index) { return default; }
	public UObject GetElementInterface(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle,UClass BaseInterfaceType) { return default; }
	public bool HasElements(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType/*=nullptr*/) { return default; }
	public int CountElements(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType/*=nullptr*/) { return default; }
	public bool HasElementsOfType(FScriptTypedElementListProxy ElementList,string ElementTypeName) { return default; }
	public int CountElementsOfType(FScriptTypedElementListProxy ElementList,string ElementTypeName) { return default; }
	public TArray<FScriptTypedElementHandle> GetElementHandles(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType) { return default; }
	public bool IsValidIndex(FScriptTypedElementListProxy ElementList,int Index) { return default; }
	public int Num(FScriptTypedElementListProxy ElementList) { return default; }
	public void Shrink(FScriptTypedElementListProxy ElementList) {}
	public void Reserve(FScriptTypedElementListProxy ElementList,int Size) {}
	public void Empty(FScriptTypedElementListProxy ElementList,int Slack/*=0*/) {}
	public void Reset(FScriptTypedElementListProxy ElementList) {}
	public bool Contains(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
	public bool Add(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
	public void Append(FScriptTypedElementListProxy ElementList,TArray<FScriptTypedElementHandle> ElementHandles) {}
	public void AppendList(FScriptTypedElementListProxy ElementList,FScriptTypedElementListProxy OtherElementList) {}
	public bool Remove(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
}
