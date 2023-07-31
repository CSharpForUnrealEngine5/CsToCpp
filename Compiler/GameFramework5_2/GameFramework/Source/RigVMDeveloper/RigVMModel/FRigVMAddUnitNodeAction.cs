#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action adding a unit node to the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddUnitNodeAction {
	public string ScriptStructPath;
	public string MethodName;
	public FVector2D Position;
	public string NodePath;
}
