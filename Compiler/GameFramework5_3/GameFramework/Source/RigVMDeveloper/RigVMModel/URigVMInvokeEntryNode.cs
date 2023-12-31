namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Invoke Entry Node is used to invoke another entry from the</summary>
[CppInclude("RigVMModel/Nodes/RigVMInvokeEntryNode.h")]
public partial class URigVMInvokeEntryNode : URigVMNode {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the name of the entry to run</summary>
	public FName GetEntryName() { return default; }
}
