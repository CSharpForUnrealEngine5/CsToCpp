namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMMemoryCommon.h")]
///<summary>The type of memory used. Typically we differentiate between</summary>
public enum ERigVMMemoryType {
	Work=0,
	Literal=1,
	External=2,
	Debug=3,
	Invalid=4,
}
