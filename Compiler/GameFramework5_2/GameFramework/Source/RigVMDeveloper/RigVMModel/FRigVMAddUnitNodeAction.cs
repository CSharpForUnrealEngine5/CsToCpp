namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding a unit node to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddUnitNodeAction {
	public string ScriptStructPath;
	public FName MethodName;
	public FVector2D Position;
	public string NodePath;
}
