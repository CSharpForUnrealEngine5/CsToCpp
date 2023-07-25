#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMFunctionLibrary.h")]
///<summary>The Function Library is a graph used only to store</summary>
public partial class URigVMFunctionLibrary : URigVMGraph {
// RigVMFunctionLibrary
	public TArray<UObject> GetFunctions() { return default; }
	public UObject FindFunction(string InFunctionName) { return default; }
	public UObject FindFunctionForNode(UObject InNode) { return default; }
	public TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>> GetReferencesForFunction(string InFunctionName) { return default; }
	public TArray<string> GetReferencePathsForFunction(string InFunctionName) { return default; }
	public TArray<string> PublicFunctionNames;
	public TMap<URigVMLibraryNode,FRigVMFunctionReferenceArray> FunctionReferences_DEPRECATED;
	public TMap<string,URigVMLibraryNode> LocalizedFunctions;
}
