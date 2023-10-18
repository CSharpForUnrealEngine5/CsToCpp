namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/RigVMEditorMenuContext.h")]
public partial class URigVMEditorMenuContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the rigvm blueprint that we are editing</summary>
	public URigVMBlueprint GetRigVMBlueprint() { return default; }
	///<summary>Get the active rigvm host instance in the viewport</summary>
	public URigVMHost GetRigVMHost() { return default; }
	///<summary>Returns true if either alt key is down</summary>
	public bool IsAltDown() { return default; }
	///<summary>Returns context for graph node context menu</summary>
	public FRigVMEditorGraphMenuContext GetGraphMenuContext() { return default; }
}
