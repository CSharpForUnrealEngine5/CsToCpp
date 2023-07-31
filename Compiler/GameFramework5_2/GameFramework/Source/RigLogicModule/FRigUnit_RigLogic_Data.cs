#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The work data used by the FRigUnit_RigLogic</summary>
[CppInclude("RigUnit_RigLogic.h")]
public partial struct FRigUnit_RigLogic_Data {
	public TWeakObjectPtr<USkeletalMeshComponent> SkelMeshComponent;
	public TArray<int> InputCurveIndices;
	public TArray<int> HierarchyBoneIndices;
	public TArray<FRigUnit_RigLogic_IntArray> MorphTargetCurveIndices;
	public TArray<FRigUnit_RigLogic_IntArray> BlendShapeIndices;
	public TArray<FRigUnit_RigLogic_IntArray> CurveElementIndicesForAnimMaps;
	public TArray<FRigUnit_RigLogic_IntArray> RigLogicIndicesForAnimMaps;
	public uint CurrentLOD;
}
