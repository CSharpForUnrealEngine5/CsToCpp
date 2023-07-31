#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Script exposure for FScriptTypedElementHandle.</summary>
[CppInclude("Elements/Framework/TypedElementHandle.h")]
public partial class UTypedElementHandleLibrary : UObject {
	///<summary>Has this handle been initialized to a valid element?</summary>
	public static bool IsSet(FScriptTypedElementHandle ElementHandle) { return default; }
	///<summary>Release this handle and set it back to an empty state.</summary>
	public static void Release(FScriptTypedElementHandle ElementHandle) {}
	///<summary>Are these two handles equal?</summary>
	public static bool Equal(FScriptTypedElementHandle LHS,FScriptTypedElementHandle RHS) { return default; }
	///<summary>Are these two handles not equal?</summary>
	public static bool NotEqual(FScriptTypedElementHandle LHS,FScriptTypedElementHandle RHS) { return default; }
}
