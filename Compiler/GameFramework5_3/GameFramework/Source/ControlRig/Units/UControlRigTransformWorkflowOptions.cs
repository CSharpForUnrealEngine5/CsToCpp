namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/ControlRigNodeWorkflow.h")]
public partial class UControlRigTransformWorkflowOptions : UControlRigWorkflowOptions {
	public static UClass StaticClass() {return default;}
	///<summary>The type of transform to retrieve from the hierarchy</summary>
	public ERigTransformType TransformType;
	///<summary>ProvideWorkflows</summary>
	public TArray<FRigVMUserWorkflow> ProvideWorkflows(UObject InSubject) { return default; }
}
