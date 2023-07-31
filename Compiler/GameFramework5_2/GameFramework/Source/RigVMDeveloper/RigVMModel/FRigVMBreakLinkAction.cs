#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action removing a link from the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMBreakLinkAction {
	public FSoftObjectPath GraphPath;
	public string OutputPinPath;
	public string InputPinPath;
}
