#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMUserWorkflow.h")]
public partial class URigVMUserWorkflowOptions : UObject {
// RigVMUserWorkflowOptions
	public  bool IsValid() { return default; }
	public  bool RequiresDialog() { return default; }
	public  void ReportError(string InMessage) {}
	public  void ReportWarning(string InMessage) {}
	public  void ReportInfo(string InMessage) {}
	public UObject Subject;
	public FRigVMUserWorkflow Workflow;
}
