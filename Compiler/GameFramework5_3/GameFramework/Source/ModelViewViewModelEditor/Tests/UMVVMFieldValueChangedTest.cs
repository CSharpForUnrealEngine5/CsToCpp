namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/MVVMFieldValueChangedTest.h")]
public partial class UMVVMFieldValueChangedTest : UMVVMViewModelBase {
	public static UClass StaticClass() {return default;}
	///<summary>PropertyInt</summary>
	public int PropertyInt;
	///<summary>PropertyFloat</summary>
	public float PropertyFloat;
	///<summary>FunctionInt</summary>
	public int FunctionInt() { return default; }
	///<summary>FunctionFloat</summary>
	public float FunctionFloat() { return default; }
}
