#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to add a node from a text buffer</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMImportNodeFromTextAction {
	public FVector2D Position;
	public string NodePath;
	public string ExportedText;
}
