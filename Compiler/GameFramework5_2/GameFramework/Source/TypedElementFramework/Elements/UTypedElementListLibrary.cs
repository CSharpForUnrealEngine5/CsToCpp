namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Framework/TypedElementListLibrary.h")]
public partial class UTypedElementListLibrary : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Create an empty list of elements associated with the given registry.</summary>
	public static FScriptTypedElementListProxy CreateScriptElementList(UTypedElementRegistry Registry) { return default; }
	///<summary>Clone this list instance.</summary>
	public static FScriptTypedElementListProxy Clone(FScriptTypedElementListProxy ElementList) { return default; }
	///<summary>Get the element handle at the given index.</summary>
	public static FScriptTypedElementHandle GetElementHandleAt(FScriptTypedElementListProxy ElementList,int Index) { return default; }
	///<summary>Get the element interface from the given handle.</summary>
	public static UObject GetElementInterface(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle,UClass BaseInterfaceType) { return default; }
	///<summary>Test whether there are elements in this list, optionally filtering to elements that implement the given interface.</summary>
	public static bool HasElements(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType/*=nullptr*/) { return default; }
	///<summary>Count the number of elements in this list, optionally filtering to elements that implement the given interface.</summary>
	public static int CountElements(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType/*=nullptr*/) { return default; }
	///<summary>Test whether there are elements in this list of the given type.</summary>
	public static bool HasElementsOfType(FScriptTypedElementListProxy ElementList,string ElementTypeName) { return default; }
	///<summary>Count the number of elements in this list of the given type.</summary>
	public static int CountElementsOfType(FScriptTypedElementListProxy ElementList,string ElementTypeName) { return default; }
	///<summary>Get the handle of every element in this list, optionally filtering to elements that implement the given interface.</summary>
	public static TArray<FScriptTypedElementHandle> GetElementHandles(FScriptTypedElementListProxy ElementList,UClass BaseInterfaceType) { return default; }
	///<summary>Is the given index a valid entry within this element list?</summary>
	public static bool IsValidIndex(FScriptTypedElementListProxy ElementList,int Index) { return default; }
	///<summary>Get the number of entries within this element list.</summary>
	public static int Num(FScriptTypedElementListProxy ElementList) { return default; }
	///<summary>Shrink this element list storage to avoid slack.</summary>
	public static void Shrink(FScriptTypedElementListProxy ElementList) {}
	///<summary>Pre-allocate enough memory in this element list to store the given number of entries.</summary>
	public static void Reserve(FScriptTypedElementListProxy ElementList,int Size) {}
	///<summary>Remove all entries from this element list, potentially leaving space allocated for the given number of entries.</summary>
	public static void Empty(FScriptTypedElementListProxy ElementList,int Slack/*=0*/) {}
	///<summary>Remove all entries from this element list, preserving existing allocations.</summary>
	public static void Reset(FScriptTypedElementListProxy ElementList) {}
	///<summary>Does this element list contain an entry for the given element handle?</summary>
	public static bool Contains(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
	///<summary>Add the given element handle to this element list, if it isn&#39;t already in the list.</summary>
	public static bool Add(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
	///<summary>Append the given element handles to this element list.</summary>
	public static void Append(FScriptTypedElementListProxy ElementList,TArray<FScriptTypedElementHandle> ElementHandles) {}
	///<summary>Append the another element list to this element list.</summary>
	public static void AppendList(FScriptTypedElementListProxy ElementList,FScriptTypedElementListProxy OtherElementList) {}
	///<summary>Remove the given element handle from this element list, if it is in the list.</summary>
	public static bool Remove(FScriptTypedElementListProxy ElementList,FScriptTypedElementHandle ElementHandle) { return default; }
}
