namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_CallFunctionOnMember.h")]
public partial class UK2Node_CallFunctionOnMember : UK2Node_CallFunction {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to member variable to call function on</summary>
	public FMemberReference MemberVariableToCallOn;
}
