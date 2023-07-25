#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementHierarchyInterface.h")]
public partial class UTypedElementHierarchyInterface : UInterface {
// TypedElementHierarchyInterface
	public FScriptTypedElementHandle GetParentElement(FScriptTypedElementHandle InElementHandle,bool bAllowCreate/*=true*/) { return default; }
	public void GetChildElements(FScriptTypedElementHandle InElementHandle,TArray<FScriptTypedElementHandle> OutElementHandles,bool bAllowCreate/*=true*/) {}
}
