#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionHost.h")]
///<summary>A management struct containing graph functions</summary>
public partial struct FRigVMGraphFunctionStore {
// RigVMGraphFunctionStore
	public TArray<FRigVMGraphFunctionData> PublicFunctions;
	public TArray<FRigVMGraphFunctionData> PrivateFunctions;
}
