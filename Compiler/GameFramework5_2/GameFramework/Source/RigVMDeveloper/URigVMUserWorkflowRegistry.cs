namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMUserWorkflowRegistry.h")]
public partial class URigVMUserWorkflowRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get</summary>
	public static URigVMUserWorkflowRegistry Get() { return default; }
	///<summary>RegisterProvider</summary>
	public int RegisterProvider(UScriptStruct InStruct,FRigVMUserWorkflowProvider InProvider) { return default; }
	///<summary>UnregisterProvider</summary>
	public void UnregisterProvider(int InHandle) {}
	///<summary>GetWorkflows</summary>
	public TArray<FRigVMUserWorkflow> GetWorkflows(ERigVMUserWorkflowType InType,UScriptStruct InStruct,UObject InSubject) { return default; }
}
