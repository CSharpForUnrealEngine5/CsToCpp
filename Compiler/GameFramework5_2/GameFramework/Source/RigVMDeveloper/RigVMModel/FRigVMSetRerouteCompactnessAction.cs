namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action setting a reroute node&#39;s compactness in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMSetRerouteCompactnessAction {
	public string NodePath;
	public bool OldShowAsFullNode;
	public bool NewShowAsFullNode;
}
