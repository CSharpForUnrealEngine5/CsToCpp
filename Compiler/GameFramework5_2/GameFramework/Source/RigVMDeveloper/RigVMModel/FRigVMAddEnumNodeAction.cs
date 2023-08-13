namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding an enum node to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddEnumNodeAction {
	public string CPPType;
	public string CPPTypeObjectPath;
	public FVector2D Position;
	public string NodePath;
}
