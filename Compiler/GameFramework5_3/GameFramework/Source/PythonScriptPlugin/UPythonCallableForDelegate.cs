namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UObject proxy base used to wrap a callable Python object so that it can be used with an Unreal delegate</summary>
[CppInclude("PyWrapperDelegate.h")]
public partial class UPythonCallableForDelegate : UObject {
	public static UClass StaticClass() {return default;}
}
