namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Struct Node represents a Function Invocation of a RIGVM_METHOD</summary>
[CppInclude("RigVMModel/Nodes/RigVMUnitNode.h")]
public partial class URigVMUnitNode : URigVMTemplateNode {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the name of the declared RIGVM_METHOD</summary>
	public virtual FName GetMethodName() { return default; }
	///<summary>Returns the default value for the struct as text</summary>
	public string GetStructDefaultValue() { return default; }
	///<summary>ScriptStruct_DEPRECATED</summary>
	public UScriptStruct ScriptStruct_DEPRECATED;
	///<summary>MethodName_DEPRECATED</summary>
	public FName MethodName_DEPRECATED;
}
