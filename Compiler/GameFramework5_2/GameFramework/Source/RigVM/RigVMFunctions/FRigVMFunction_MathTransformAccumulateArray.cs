namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Treats the provided transforms as a chain with global / local transforms, and</summary>
[CppInclude("RigVMFunctions/Math/RigVMFunction_MathTransform.h")]
public partial struct FRigVMFunction_MathTransformAccumulateArray {
	public TArray<FTransform> Transforms;
	public ERigVMTransformSpace TargetSpace;
	public FTransform Root;
	public TArray<int> ParentIndices;
}
