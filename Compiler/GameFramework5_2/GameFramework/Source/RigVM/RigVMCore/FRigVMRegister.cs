namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The register represents an address with the VM&#39;s memory. Within a register</summary>
[CppInclude("RigVMCore/RigVMMemoryDeprecated.h")]
public partial struct FRigVMRegister {
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
