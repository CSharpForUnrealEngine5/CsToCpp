namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Unit for getting a pose via an anim interface</summary>
[CppInclude("RigUnit_AnimNextInterfaceParameter.h")]
public partial struct FRigUnit_PoseOperator {
	public object /*Operator*/ Operator;
	public TArray<FRigVMExecuteContext> InputPoses;
	public FAnimNextInterfaceParameters1 Parameters;
	public FAnimNextInterfaceExecuteContext Result;
}
