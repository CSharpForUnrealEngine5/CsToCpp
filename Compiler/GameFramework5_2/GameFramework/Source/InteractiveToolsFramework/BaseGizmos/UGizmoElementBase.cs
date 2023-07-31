#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for 2d and 3d primitive objects intended to be used as part of 3D Gizmos.</summary>
[CppInclude("BaseGizmos/GizmoElementBase.h")]
public partial class UGizmoElementBase : UObject {
	///<summary>Whether element is enabled. Render and LineTrace only occur when bEnabled is true.</summary>
	public bool bEnabled;
	///<summary>Whether element is enabled for perspective projection</summary>
	public bool bEnabledForPerspectiveProjection;
	///<summary>Whether element is enabled for orthographic projection</summary>
	public bool bEnabledForOrthographicProjection;
	///<summary>Whether element is enabled when element state is default</summary>
	public bool bEnabledForDefaultState;
	///<summary>Whether element is enabled when element state is hovering</summary>
	public bool bEnabledForHoveringState;
	///<summary>Whether element is enabled when element state is interacting</summary>
	public bool bEnabledForInteractingState;
	///<summary>Part identifier</summary>
	public uint PartIdentifier;
	///<summary>Mesh render state attributes for this element</summary>
	public FGizmoElementMeshRenderStateAttributes MeshRenderAttributes;
	///<summary>Element state - indicates whether object is visible or hittable</summary>
	public EGizmoElementState ElementState;
	///<summary>Current element interaction state - None, Hovering or Interacting</summary>
	public EGizmoElementInteractionState ElementInteractionState;
	///<summary>View-dependent type - None, Axis or Plane.</summary>
	public EGizmoElementViewDependentType ViewDependentType;
	///<summary>View-dependent axis or plane normal, based on the view-dependent type.</summary>
	public FVector ViewDependentAxis;
	///<summary>View-dependent angle tolerance based on :</summary>
	public float ViewDependentAngleTol;
	///<summary>Axial view alignment minimum cos angle tolerance, computed based on ViewDependentAngleTol.</summary>
	public float ViewDependentAxialMaxCosAngleTol;
	///<summary>Planar view alignment minimum cos angle tolerance, computed based on ViewDependentAngleTol.</summary>
	public float ViewDependentPlanarMinCosAngleTol;
	///<summary>View align type: None, PointEye, or PointWorld.</summary>
	public EGizmoElementViewAlignType ViewAlignType;
	///<summary>View align axis.</summary>
	public FVector ViewAlignAxis;
	///<summary>View align normal.</summary>
	public FVector ViewAlignNormal;
	///<summary>Axial view alignment angle tolerance in radians, based on angle between align normal and view direction.</summary>
	public float ViewAlignAxialAngleTol;
	///<summary>Axial view alignment minimum cos angle tolerance, computed based on ViewAlignAxialAngleTol.</summary>
	public float ViewAlignAxialMaxCosAngleTol;
	///<summary>Pixel hit distance threshold, element will be scaled enough to add this threshold when line-tracing.</summary>
	public float PixelHitDistanceThreshold;
}
