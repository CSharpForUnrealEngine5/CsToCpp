namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TypedElementFrameworkTests.h")]
public partial class UTestTypedElementInterfaceA : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>GetDisplayName</summary>
	public virtual FText GetDisplayName(FScriptTypedElementHandle InElementHandle) { return default; }
	///<summary>SetDisplayName</summary>
	public virtual bool SetDisplayName(FScriptTypedElementHandle InElementHandle,FText InNewName,bool bNotify/*=true*/) { return default; }
}
