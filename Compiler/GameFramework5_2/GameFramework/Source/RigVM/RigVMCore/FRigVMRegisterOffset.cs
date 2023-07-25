#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMMemoryDeprecated.h")]
///<summary>The register offset represents a memory offset within a register's memory.</summary>
public partial struct FRigVMRegisterOffset {
// RigVMRegisterOffset
	public TArray<int> Segments;
	public ERigVMRegisterType Type;
	public string CPPType;
	public UScriptStruct ScriptStruct;
	public UScriptStruct ParentScriptStruct;
	public int ArrayIndex;
	public ushort ElementSize;
	public string CachedSegmentPath;
}
