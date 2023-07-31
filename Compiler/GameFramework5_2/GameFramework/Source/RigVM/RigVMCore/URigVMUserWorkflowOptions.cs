#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMUserWorkflow.h")]
public partial class URigVMUserWorkflowOptions : UObject {
	///<summary>IsValid</summary>
	public  bool IsValid() { return default; }
	///<summary>RequiresDialog</summary>
	public  bool RequiresDialog() { return default; }
	///<summary>ReportError</summary>
	public  void ReportError(string InMessage) {}
	///<summary>ReportWarning</summary>
	public  void ReportWarning(string InMessage) {}
	///<summary>ReportInfo</summary>
	public  void ReportInfo(string InMessage) {}
	///<summary>Subject</summary>
	public UObject Subject;
	///<summary>Workflow</summary>
	public FRigVMUserWorkflow Workflow;
}
