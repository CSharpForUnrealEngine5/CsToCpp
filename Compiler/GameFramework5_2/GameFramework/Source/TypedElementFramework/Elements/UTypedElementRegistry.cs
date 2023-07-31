#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Registry of element types and their associated interfaces, along with the elements that represent their instances.</summary>
[CppInclude("Elements/Framework/TypedElementRegistry.h")]
public partial class UTypedElementRegistry : UObject {
	///<summary>Get the singleton instance of the registry used in most cases.</summary>
	public static UTypedElementRegistry GetInstance() { return default; }
	///<summary>Get the element interface supported by the given handle, or null if there is no support for this interface or if the handle is invalid.</summary>
	public  UObject GetElementInterface(FScriptTypedElementHandle InElementHandle,UClass InBaseInterfaceType) { return default; }
}
