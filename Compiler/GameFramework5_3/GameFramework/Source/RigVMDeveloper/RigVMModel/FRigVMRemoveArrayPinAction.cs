namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action removing an array pin from the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMRemoveArrayPinAction {
	public string ArrayPinPath;
	public int Index;
	public string DefaultValue;
}
