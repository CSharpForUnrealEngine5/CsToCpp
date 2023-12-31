namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_Variable.h")]
public partial class UK2Node_Variable : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to variable we want to set/get</summary>
	public FMemberReference VariableReference;
	///<summary>SelfContextInfo</summary>
	public ESelfContextInfo SelfContextInfo;
	///<summary>Class that this variable is defined in. Should be NULL if bSelfContext is true.</summary>
	public UClass VariableSourceClass_DEPRECATED;
	///<summary>Name of variable</summary>
	public FName VariableName_DEPRECATED;
	///<summary>Whether or not this should be a &quot;self&quot; context</summary>
	public bool bSelfContext_DEPRECATED;
}
