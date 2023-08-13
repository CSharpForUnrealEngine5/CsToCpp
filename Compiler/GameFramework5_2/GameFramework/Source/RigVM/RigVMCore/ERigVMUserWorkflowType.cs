namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMUserWorkflow.h")]
///<summary>Types of workflows offered by a rigvm struct node</summary>
public enum ERigVMUserWorkflowType {
	Invalid=0,
	NodeContext=1,
	PinContext=2,
	OnPinDefaultChanged=4,
	All=-1,
}
