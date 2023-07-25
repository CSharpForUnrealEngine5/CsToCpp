#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMMemoryDeprecated.h")]
///<summary>The FRigVMMemoryContainer provides a heterogeneous memory container to store arbitrary</summary>
public partial struct FRigVMMemoryContainer {
// RigVMMemoryContainer
	public bool bUseNameMap;
	public ERigVMMemoryType MemoryType;
	public TArray<FRigVMRegister> Registers;
	public TArray<FRigVMRegisterOffset> RegisterOffsets;
	public TArray<byte> Data;
	public TArray<UScriptStruct> ScriptStructs;
	public TMap<string,int> NameMap;
	public bool bEncounteredErrorDuringLoad;
}
