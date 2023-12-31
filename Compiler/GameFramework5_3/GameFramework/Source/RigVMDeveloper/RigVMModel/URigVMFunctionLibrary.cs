namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Function Library is a graph used only to store</summary>
[CppInclude("RigVMModel/RigVMFunctionLibrary.h")]
public partial class URigVMFunctionLibrary : URigVMGraph {
	public static UClass StaticClass() {return default;}
	///<summary>Returns all of the stored functions</summary>
	public TArray<URigVMLibraryNode> GetFunctions() { return default; }
	///<summary>Finds a function by name</summary>
	public URigVMLibraryNode FindFunction(FName InFunctionName) { return default; }
	///<summary>Finds a function by a node within a function (or a sub graph of that)</summary>
	public URigVMLibraryNode FindFunctionForNode(URigVMNode InNode) { return default; }
	///<summary>Returns all references for a given function name</summary>
	public TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>> GetReferencesForFunction(FName InFunctionName) { return default; }
	///<summary>Returns all references for a given function name</summary>
	public TArray<string> GetReferencePathsForFunction(FName InFunctionName) { return default; }
	///<summary>PublicFunctionNames</summary>
	public TArray<FName> PublicFunctionNames;
	///<summary>FunctionReferences_DEPRECATED</summary>
	public TMap<URigVMLibraryNode,FRigVMFunctionReferenceArray> FunctionReferences_DEPRECATED;
	///<summary>A map which stores a library node per original pathname.</summary>
	public TMap<string,URigVMLibraryNode> LocalizedFunctions;
}
