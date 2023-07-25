#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeformMeshPolygonsTool.h")]
public partial class UDeformMeshPolygonsTransformProperties : UInteractiveToolPropertySet {
// DeformMeshPolygonsTransformProperties
	public EGroupTopologyDeformationStrategy DeformationStrategy;
	public EQuickTransformerMode TransformMode;
	public bool bSelectFaces;
	public bool bSelectEdges;
	public bool bSelectVertices;
	public bool bShowWireframe;
	public EWeightScheme SelectedWeightScheme;
	public double HandleWeight;
	public bool bPostFixHandles;
}
