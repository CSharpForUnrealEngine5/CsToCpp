namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMController.h")]
public enum ERigVMControllerBulkEditType {
	AddExposedPin=0,
	RemoveExposedPin=1,
	RenameExposedPin=2,
	ChangeExposedPinType=3,
	AddVariable=4,
	RemoveVariable=5,
	RenameVariable=6,
	ChangeVariableType=7,
	RemoveFunction=8,
	Max=9,
}
