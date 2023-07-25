#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMUserWorkflowRegistry.h")]
public partial class URigVMUserWorkflowRegistry : UObject {
// RigVMUserWorkflowRegistry
	public UObject Get() { return default; }
	public int RegisterProvider(UObject InStruct,FRigVMUserWorkflowProvider InProvider) { return default; }
	public void UnregisterProvider(int InHandle) {}
	public TArray<FRigVMUserWorkflow> GetWorkflows(ERigVMUserWorkflowType InType,UObject InStruct,UObject InSubject) { return default; }
}
