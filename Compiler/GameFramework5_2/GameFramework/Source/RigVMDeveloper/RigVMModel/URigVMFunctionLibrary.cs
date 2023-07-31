#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Function Library is a graph used only to store</summary>
[CppInclude("RigVMModel/RigVMFunctionLibrary.h")]
public partial class URigVMFunctionLibrary : URigVMGraph {
	///<summary>Returns all of the stored functions</summary>
	public  TArray<URigVMLibraryNode> GetFunctions() { return default; }
	///<summary>Finds a function by name</summary>
	public  URigVMLibraryNode FindFunction(string InFunctionName) { return default; }
	///<summary>Finds a function by a node within a function (or a sub graph of that)</summary>
	public  URigVMLibraryNode FindFunctionForNode(URigVMNode InNode) { return default; }
	///<summary>Returns all references for a given function name</summary>
	public  TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>> GetReferencesForFunction(string InFunctionName) { return default; }
	///<summary>Returns all references for a given function name</summary>
	public  TArray<string> GetReferencePathsForFunction(string InFunctionName) { return default; }
	///<summary>PublicFunctionNames</summary>
	public TArray<string> PublicFunctionNames;
	///<summary>FunctionReferences_DEPRECATED</summary>
	public TMap<URigVMLibraryNode,FRigVMFunctionReferenceArray> FunctionReferences_DEPRECATED;
	///<summary>A map which stores a library node per original pathname.</summary>
	public TMap<string,URigVMLibraryNode> LocalizedFunctions;
}
