#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_FunctionTerminator.h")]
public partial class UK2Node_FunctionTerminator : UK2Node_EditablePinBase {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the function signature. This is only resolvable by default if this is an inherited function</summary>
	public FMemberReference FunctionReference;
	///<summary>(DEPRECATED) Function signature class. Replaced by the &#39;FunctionReference&#39; property.</summary>
	public UClass SignatureClass_DEPRECATED;
	///<summary>(DEPRECATED) Function signature name. Replaced by the &#39;FunctionReference&#39; property.</summary>
	public string SignatureName_DEPRECATED;
}
