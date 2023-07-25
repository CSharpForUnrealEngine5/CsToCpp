#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigUnit_RigLogic.h")]
///<summary>The work data used by the FRigUnit_RigLogic</summary>
public partial struct FRigUnit_RigLogic_Data {
// RigUnit_RigLogic_Data
	public TWeakObjectPtr<USkeletalMeshComponent> SkelMeshComponent;
	public TArray<int> InputCurveIndices;
	public TArray<int> HierarchyBoneIndices;
	public TArray<FRigUnit_RigLogic_IntArray> MorphTargetCurveIndices;
	public TArray<FRigUnit_RigLogic_IntArray> BlendShapeIndices;
	public TArray<FRigUnit_RigLogic_IntArray> CurveElementIndicesForAnimMaps;
	public TArray<FRigUnit_RigLogic_IntArray> RigLogicIndicesForAnimMaps;
	public uint CurrentLOD;
}
