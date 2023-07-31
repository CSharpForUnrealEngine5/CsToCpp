#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
