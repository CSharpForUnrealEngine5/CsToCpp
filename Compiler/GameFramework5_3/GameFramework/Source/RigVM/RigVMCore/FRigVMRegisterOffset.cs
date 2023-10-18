namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The register offset represents a memory offset within a register&#39;s memory.</summary>
[CppInclude("RigVMCore/RigVMMemoryDeprecated.h")]
public partial struct FRigVMRegisterOffset {
	public TArray<int> Segments;
	public ERigVMRegisterType Type;
	public FName CPPType;
	public UScriptStruct ScriptStruct;
	public UScriptStruct ParentScriptStruct;
	public int ArrayIndex;
	public ushort ElementSize;
	public string CachedSegmentPath;
}
