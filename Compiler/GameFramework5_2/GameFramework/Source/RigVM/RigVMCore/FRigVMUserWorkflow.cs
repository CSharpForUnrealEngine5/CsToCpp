#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMUserWorkflow.h")]
public partial struct FRigVMUserWorkflow {
// RigVMUserWorkflow
	public string Title;
	public string Tooltip;
	public ERigVMUserWorkflowType Type;
	public FRigVMPeformUserWorkflowDynamicDelegate PerformDynamicDelegate;
	public UClass OptionsClass;
}
