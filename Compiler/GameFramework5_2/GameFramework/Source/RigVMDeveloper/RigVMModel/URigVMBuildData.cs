#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMBuildData.h")]
///<summary>The Build Data is used to store transient / intermediate build information</summary>
public partial class URigVMBuildData : UObject {
// RigVMBuildData
	public TMap<TSoftObjectPtr<URigVMLibraryNode>,FRigVMFunctionReferenceArray> FunctionReferences_DEPRECATED;
	public TMap<FRigVMGraphFunctionIdentifier,FRigVMFunctionReferenceArray> GraphFunctionReferences;
}
