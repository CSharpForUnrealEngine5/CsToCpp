#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>The Action Stack can be used to track actions happening on a</summary>
public partial class URigVMActionStack : UObject {
// RigVMActionStack
	public  bool OpenUndoBracket(string InTitle) { return default; }
	public  bool CloseUndoBracket(URigVMController InController) { return default; }
	public  bool CancelUndoBracket(URigVMController InController) { return default; }
	public  bool Undo(URigVMController InController) { return default; }
	public  bool Redo(URigVMController InController) { return default; }
	public int ActionIndex;
	public TArray<FRigVMActionKey> UndoActions;
	public TArray<FRigVMActionKey> RedoActions;
}
