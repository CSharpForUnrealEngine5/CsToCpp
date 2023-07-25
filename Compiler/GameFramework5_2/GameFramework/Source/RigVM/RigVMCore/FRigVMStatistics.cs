#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMStatistics.h")]
public partial struct FRigVMStatistics {
// RigVMStatistics
	public int BytesForCDO;
	public int BytesPerInstance;
	public FRigVMMemoryStatistics LiteralMemory;
	public FRigVMMemoryStatistics WorkMemory;
	public FRigVMMemoryStatistics DebugMemory;
	public int BytesForCaching;
	public FRigVMByteCodeStatistics ByteCode;
}
