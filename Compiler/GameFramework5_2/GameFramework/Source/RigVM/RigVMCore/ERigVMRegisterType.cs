#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMMemoryDeprecated.h")]
///<summary>The type of register within the memory.</summary>
public enum ERigVMRegisterType {
	Plain=0,
	String=1,
	Name=2,
	Struct=3,
	Invalid=4,
}
