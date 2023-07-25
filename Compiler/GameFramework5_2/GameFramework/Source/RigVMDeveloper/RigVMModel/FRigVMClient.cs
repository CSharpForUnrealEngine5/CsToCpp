#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMClient.h")]
///<summary>A management struct containing graphs and controllers.</summary>
public partial struct FRigVMClient {
// RigVMClient
	public UScriptStruct ExecuteContextStruct;
	public TArray<URigVMGraph> Models;
	public URigVMFunctionLibrary FunctionLibrary;
	public TMap<FSoftObjectPath,URigVMController> Controllers;
	public int UndoRedoIndex;
}
