namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base action class</summary>
[CppInclude("OptimusActionStack.h")]
public partial class UOptimusActionStack : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TransactedActionIndex</summary>
	public int TransactedActionIndex;
}
