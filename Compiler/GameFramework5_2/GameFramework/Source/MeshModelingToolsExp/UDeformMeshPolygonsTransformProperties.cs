namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeformMeshPolygonsTool.h")]
public partial class UDeformMeshPolygonsTransformProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Type of deformation used.</summary>
	public EGroupTopologyDeformationStrategy DeformationStrategy;
	///<summary>Type of transformation used.</summary>
	public EQuickTransformerMode TransformMode;
	///<summary>Allow for faces (PolyGroups) to be selected.</summary>
	public bool bSelectFaces;
	///<summary>Allow for edges to be selected.</summary>
	public bool bSelectEdges;
	///<summary>Allow for vertices to be selected.</summary>
	public bool bSelectVertices;
	///<summary>If true, overlays preview with wireframe.</summary>
	public bool bShowWireframe;
	///<summary>Laplacian Deformation Options, currently not exposed.</summary>
	public EWeightScheme SelectedWeightScheme;
	///<summary>HandleWeight</summary>
	public double HandleWeight;
	///<summary>bPostFixHandles</summary>
	public bool bPostFixHandles;
}
