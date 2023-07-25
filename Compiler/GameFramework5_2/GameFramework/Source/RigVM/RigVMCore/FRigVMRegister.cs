#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMMemoryDeprecated.h")]
///<summary>The register represents an address with the VM's memory. Within a register</summary>
public partial struct FRigVMRegister {
// RigVMRegister
	public ERigVMRegisterType Type;
	public uint ByteIndex;
	public ushort ElementSize;
	public ushort ElementCount;
	public ushort SliceCount;
	public byte AlignmentBytes;
	public ushort TrailingBytes;
	public string Name;
	public int ScriptStructIndex;
	public bool bIsArray;
	public bool bIsDynamic;
	public string BaseCPPType;
	public UObject BaseCPPTypeObject;
}
