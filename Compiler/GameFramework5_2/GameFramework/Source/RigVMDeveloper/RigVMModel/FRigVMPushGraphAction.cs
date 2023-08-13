namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action pushing a graph to the graph stack of the controller</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMPushGraphAction {
	public FSoftObjectPath GraphPath;
}
