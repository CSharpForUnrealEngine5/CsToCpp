namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An action inserting a new array pin in the graph.</summary>
[CppInclude("RigVMModel/RigVMControllerActions.h")]
public partial struct FRigVMInsertArrayPinAction {
	public string ArrayPinPath;
	public int Index;
	public string NewDefaultValue;
}
