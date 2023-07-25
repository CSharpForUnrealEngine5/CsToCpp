#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/ControlRigNodeWorkflow.h")]
public partial class UControlRigWorkflowOptions : URigVMUserWorkflowOptions {
// ControlRigWorkflowOptions
	public URigHierarchy Hierarchy;
	public TArray<FRigElementKey> Selection;
	public bool EnsureAtLeastOneRigElementSelected() { return default; }
}
