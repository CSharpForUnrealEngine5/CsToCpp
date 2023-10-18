namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Library Node represents a function invocation of a</summary>
[CppInclude("RigVMModel/Nodes/RigVMLibraryNode.h")]
public partial class URigVMLibraryNode : URigVMTemplateNode {
	public static UClass StaticClass() {return default;}
	///<summary>GetLibrary</summary>
	public virtual URigVMFunctionLibrary GetLibrary() { return default; }
	///<summary>GetContainedGraph</summary>
	public virtual URigVMGraph GetContainedGraph() { return default; }
}
