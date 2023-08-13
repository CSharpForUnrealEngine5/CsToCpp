namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMUserWorkflow.h")]
public partial struct FRigVMUserWorkflow {
	public string Title;
	public string Tooltip;
	public ERigVMUserWorkflowType Type;
	public FRigVMPeformUserWorkflowDynamicDelegate PerformDynamicDelegate;
	public UClass OptionsClass;
}
