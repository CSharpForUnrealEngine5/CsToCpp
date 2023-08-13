namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PyTestInterface.h")]
public partial class UPyTestChildInterface : UPyTestInterface {
	public static UClass StaticClass() {return default;}
	///<summary>FuncInterfaceChild</summary>
	public virtual int FuncInterfaceChild(int InValue) { return default; }
}
