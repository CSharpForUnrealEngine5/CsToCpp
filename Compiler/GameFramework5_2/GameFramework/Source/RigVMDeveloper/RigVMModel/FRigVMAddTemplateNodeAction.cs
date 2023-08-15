namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding a template node to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddTemplateNodeAction {
	public FName TemplateNotation;
	public FVector2D Position;
	public string NodePath;
}
