namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The FRigVMMemoryContainer provides a heterogeneous memory container to store arbitrary</summary>
[CppInclude("RigVMCore/RigVMMemoryDeprecated.h")]
public partial struct FRigVMMemoryContainer {
	public bool bUseNameMap;
	public ERigVMMemoryType MemoryType;
	public TArray<FRigVMRegister> Registers;
	public TArray<FRigVMRegisterOffset> RegisterOffsets;
	public TArray<byte> Data;
	public TArray<UScriptStruct> ScriptStructs;
	public TMap<FName,int> NameMap;
	public bool bEncounteredErrorDuringLoad;
}
