namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMFunctionCompilationData {
	public FRigVMByteCode ByteCode;
	public TArray<FName> FunctionNames;
	public TArray<FRigVMFunctionCompilationPropertyDescription> WorkPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> WorkPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> LiteralPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> LiteralPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> DebugPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> DebugPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> ExternalPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> ExternalPropertyPathDescriptions;
	public TMap<int,FName> ExternalRegisterIndexToVariable;
	public TMap<string,FRigVMOperand> Operands;
	public uint Hash;
}
