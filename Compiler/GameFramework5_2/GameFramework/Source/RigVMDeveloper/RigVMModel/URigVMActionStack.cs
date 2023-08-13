namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Action Stack can be used to track actions happening on a</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial class URigVMActionStack : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Opens an undo bracket / scope to record actions into.</summary>
	public bool OpenUndoBracket(string InTitle) { return default; }
	///<summary>Closes an undo bracket / scope.</summary>
	public bool CloseUndoBracket(URigVMController InController) { return default; }
	///<summary>Cancels an undo bracket / scope.</summary>
	public bool CancelUndoBracket(URigVMController InController) { return default; }
	///<summary>Pops the last action from the undo stack and perform undo on it.</summary>
	public bool Undo(URigVMController InController) { return default; }
	///<summary>Pops the last action from the redo stack and perform redo on it.</summary>
	public bool Redo(URigVMController InController) { return default; }
	///<summary>ActionIndex</summary>
	public int ActionIndex;
	///<summary>UndoActions</summary>
	public TArray<FRigVMActionKey> UndoActions;
	///<summary>RedoActions</summary>
	public TArray<FRigVMActionKey> RedoActions;
}
