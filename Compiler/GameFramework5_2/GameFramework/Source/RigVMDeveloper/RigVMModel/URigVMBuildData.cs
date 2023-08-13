namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Build Data is used to store transient / intermediate build information</summary>
[CppInclude("RigVMModel/RigVMBuildData.h")]
public partial class URigVMBuildData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FunctionReferences_DEPRECATED</summary>
	public TMap<TSoftObjectPtr<URigVMLibraryNode>,FRigVMFunctionReferenceArray> FunctionReferences_DEPRECATED;
	///<summary>GraphFunctionReferences</summary>
	public TMap<FRigVMGraphFunctionIdentifier,FRigVMFunctionReferenceArray> GraphFunctionReferences;
}
