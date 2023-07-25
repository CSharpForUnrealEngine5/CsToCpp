#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Selection/MeshTopologySelectionMechanic.h")]
public partial class UMeshTopologySelectionMechanicProperties : UInteractiveToolPropertySet {
// MeshTopologySelectionMechanicProperties
	public bool bSelectVertices;
	public bool bSelectEdges;
	public bool bSelectFaces;
	public bool bSelectEdgeLoops;
	public bool bSelectEdgeRings;
	public bool bHitBackFaces;
	public bool bEnableMarquee;
	public bool bMarqueeIgnoreOcclusion;
	public bool bPreferProjectedElement;
	public bool bSelectDownRay;
	public bool bIgnoreOcclusion;
	public void InvertSelection() {}
	public void SelectAll() {}
}
