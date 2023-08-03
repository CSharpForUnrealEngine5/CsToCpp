#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Selection/MeshTopologySelectionMechanic.h")]
public partial class UMeshTopologySelectionMechanicProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>bSelectVertices</summary>
	public bool bSelectVertices;
	///<summary>bSelectEdges</summary>
	public bool bSelectEdges;
	///<summary>bSelectFaces</summary>
	public bool bSelectFaces;
	///<summary>When true, will select edge loops. Edge loops are paths along a string of valence-4 vertices.</summary>
	public bool bSelectEdgeLoops;
	///<summary>When set, will select rings of edges that are opposite each other across a quad face.</summary>
	public bool bSelectEdgeRings;
	///<summary>When set, faces that face away from the camera are ignored in selection and occlusion. Useful for working with inside-out meshes.</summary>
	public bool bHitBackFaces;
	///<summary>bEnableMarquee</summary>
	public bool bEnableMarquee;
	///<summary>Determines whether vertices should be checked for occlusion in marquee select (Note: marquee select currently only works with edges and vertices)</summary>
	public bool bMarqueeIgnoreOcclusion;
	///<summary>Prefer to select an edge projected to a point rather than the point, or a face projected to an edge rather than the edge.</summary>
	public bool bPreferProjectedElement;
	///<summary>If the closest element is valid, select other elements behind it that are aligned with it.</summary>
	public bool bSelectDownRay;
	///<summary>Do not check whether the closest element is occluded from the current view.</summary>
	public bool bIgnoreOcclusion;
	///<summary>Invert current selection. If selection is empty, has same effect as Select All, and is similarly dependent on selection filter.</summary>
	public  void InvertSelection() {}
	///<summary>Select all elements. Depends on selection filter, where vertices are preferred to edges to faces.</summary>
	public  void SelectAll() {}
}
