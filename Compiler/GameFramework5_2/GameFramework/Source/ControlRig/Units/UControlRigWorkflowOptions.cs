namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/ControlRigNodeWorkflow.h")]
public partial class UControlRigWorkflowOptions : URigVMUserWorkflowOptions {
	public static UClass StaticClass() {return default;}
	///<summary>Hierarchy</summary>
	public URigHierarchy Hierarchy;
	///<summary>Selection</summary>
	public TArray<FRigElementKey> Selection;
	///<summary>EnsureAtLeastOneRigElementSelected</summary>
	public bool EnsureAtLeastOneRigElementSelected() { return default; }
}
