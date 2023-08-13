namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action popping a graph from the graph stack of the controller</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMPopGraphAction {
	public FSoftObjectPath GraphPath;
}
