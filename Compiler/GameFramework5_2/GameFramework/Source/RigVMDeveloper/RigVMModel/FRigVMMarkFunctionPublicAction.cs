#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action marking a function as public/private.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMMarkFunctionPublicAction {
	public string FunctionName;
	public bool bIsPublic;
}
