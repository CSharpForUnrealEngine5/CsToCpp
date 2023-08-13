namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action marking a function as public/private.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMMarkFunctionPublicAction {
	public string FunctionName;
	public bool bIsPublic;
}
