#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementObjectInterface.h")]
public partial class UTypedElementObjectInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Get the object instance that this handle represents, if any.</summary>
	public  UObject GetObject(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>Gets the object instance&#39;s class that the handle represents, if any.</summary>
	public  UClass GetObjectClass(FScriptTypedElementHandle InElementHandle) { return default; }
}
