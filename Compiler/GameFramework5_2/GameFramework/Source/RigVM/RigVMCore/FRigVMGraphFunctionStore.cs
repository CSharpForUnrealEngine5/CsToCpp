namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A management struct containing graph functions</summary>
[CppInclude("RigVMCore/RigVMGraphFunctionHost.h")]
public partial struct FRigVMGraphFunctionStore {
	public TArray<FRigVMGraphFunctionData> PublicFunctions;
	public TArray<FRigVMGraphFunctionData> PrivateFunctions;
}
