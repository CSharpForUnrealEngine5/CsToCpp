#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMFunctionCompilationData {
	public FRigVMByteCode ByteCode;
	public TArray<string> FunctionNames;
	public TArray<FRigVMFunctionCompilationPropertyDescription> WorkPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> WorkPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> LiteralPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> LiteralPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> DebugPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> DebugPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> ExternalPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> ExternalPropertyPathDescriptions;
	public TMap<int,string> ExternalRegisterIndexToVariable;
	public TMap<string,FRigVMOperand> Operands;
	public uint Hash;
}
