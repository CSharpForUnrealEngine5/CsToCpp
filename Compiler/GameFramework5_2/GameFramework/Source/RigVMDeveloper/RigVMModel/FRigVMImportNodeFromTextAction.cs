namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to add a node from a text buffer</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMImportNodeFromTextAction {
	public FVector2D Position;
	public string NodePath;
	public string ExportedText;
}
