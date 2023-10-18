namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The action key is used for serializing and storing an action in the stack,</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMActionKey {
	public string ScriptStructPath;
	public string ExportedText;
}
