#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
///<summary>Treats the provided transforms as a chain with global / local transforms, and</summary>
public partial struct FRigVMFunction_MathTransformAccumulateArray {
// RigVMFunction_MathTransformAccumulateArray
	public TArray<FTransform> Transforms;
	public ERigVMTransformSpace TargetSpace;
	public FTransform Root;
	public TArray<int> ParentIndices;
}
