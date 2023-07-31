#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMUserWorkflowRegistry.h")]
public partial class URigVMUserWorkflowRegistry : UObject {
	///<summary>Get</summary>
	public static URigVMUserWorkflowRegistry Get() { return default; }
	///<summary>RegisterProvider</summary>
	public  int RegisterProvider(UScriptStruct InStruct,FRigVMUserWorkflowProvider InProvider) { return default; }
	///<summary>UnregisterProvider</summary>
	public  void UnregisterProvider(int InHandle) {}
	///<summary>GetWorkflows</summary>
	public  TArray<FRigVMUserWorkflow> GetWorkflows(ERigVMUserWorkflowType InType,UScriptStruct InStruct,UObject InSubject) { return default; }
}
