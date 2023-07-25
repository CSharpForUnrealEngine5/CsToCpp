#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoElementBase.h")]
///<summary>Base class for 2d and 3d primitive objects intended to be used as part of 3D Gizmos.</summary>
public partial class UGizmoElementBase : UObject {
// GizmoElementBase
	public bool bEnabled;
	public bool bEnabledForPerspectiveProjection;
	public bool bEnabledForOrthographicProjection;
	public bool bEnabledForDefaultState;
	public bool bEnabledForHoveringState;
	public bool bEnabledForInteractingState;
	public uint PartIdentifier;
	public FGizmoElementMeshRenderStateAttributes MeshRenderAttributes;
	public EGizmoElementState ElementState;
	public EGizmoElementInteractionState ElementInteractionState;
	public EGizmoElementViewDependentType ViewDependentType;
	public FVector ViewDependentAxis;
	public float ViewDependentAngleTol;
	public float ViewDependentAxialMaxCosAngleTol;
	public float ViewDependentPlanarMinCosAngleTol;
	public EGizmoElementViewAlignType ViewAlignType;
	public FVector ViewAlignAxis;
	public FVector ViewAlignNormal;
	public float ViewAlignAxialAngleTol;
	public float ViewAlignAxialMaxCosAngleTol;
	public float PixelHitDistanceThreshold;
}
