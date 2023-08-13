namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMStatistics.h")]
public partial struct FRigVMStatistics {
	public int BytesForCDO;
	public int BytesPerInstance;
	public FRigVMMemoryStatistics LiteralMemory;
	public FRigVMMemoryStatistics WorkMemory;
	public FRigVMMemoryStatistics DebugMemory;
	public int BytesForCaching;
	public FRigVMByteCodeStatistics ByteCode;
}
