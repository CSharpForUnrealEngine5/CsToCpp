#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TypedElementFrameworkTests.h")]
public partial class UTestTypedElementInterfaceA : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>GetDisplayName</summary>
	public  string GetDisplayName(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>SetDisplayName</summary>
	public  bool SetDisplayName(FScriptTypedElementHandle InElementHandle,string InNewName,bool bNotify/*=true*/) { return default; }
}
