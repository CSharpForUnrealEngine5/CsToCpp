#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base action is the base struct for all actions, and provides</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMBaseAction {
	public string Title;
	public TArray<FRigVMActionKey> SubActions;
}
