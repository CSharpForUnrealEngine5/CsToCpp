namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action to add a decorator to a node</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMAddDecoratorAction {
	public FName NodeName;
	public FName DecoratorName;
	public string ScriptStructPath;
	public string DecoratorDefault;
	public int PinIndex;
}
