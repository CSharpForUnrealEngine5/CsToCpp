namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementHierarchyInterface.h")]
public partial class UTypedElementHierarchyInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Get the logical parent of this element, if any.</summary>
	public virtual FScriptTypedElementHandle GetParentElement(FScriptTypedElementHandle InElementHandle,bool bAllowCreate/*=true*/) { return default; }
	///<summary>Get the logical children of this element, if any.</summary>
	public virtual void GetChildElements(FScriptTypedElementHandle InElementHandle,TArray<FScriptTypedElementHandle> OutElementHandles,bool bAllowCreate/*=true*/) {}
}
