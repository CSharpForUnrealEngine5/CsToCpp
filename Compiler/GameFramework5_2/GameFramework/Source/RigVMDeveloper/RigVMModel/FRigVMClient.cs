namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A management struct containing graphs and controllers.</summary>
[CppInclude("RigVMModel/RigVMClient.h")]
public partial struct FRigVMClient {
	public UScriptStruct ExecuteContextStruct;
	public TArray<URigVMGraph> Models;
	public URigVMFunctionLibrary FunctionLibrary;
	public TMap<FSoftObjectPath,URigVMController> Controllers;
	public int UndoRedoIndex;
}
