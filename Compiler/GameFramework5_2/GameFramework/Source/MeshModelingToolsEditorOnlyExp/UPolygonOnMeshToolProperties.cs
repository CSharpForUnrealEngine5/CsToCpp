#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PolygonOnMeshTool.h")]
///<summary>Standard properties of the polygon-on-mesh operations</summary>
public partial class UPolygonOnMeshToolProperties : UInteractiveToolPropertySet {
// PolygonOnMeshToolProperties
	public EEmbeddedPolygonOpMethod Operation;
	public EPolygonType Shape;
	public bool bCutWithBoolean;
	public bool bTryToFixHoles;
	public float PolygonScale;
	public float Width;
	public float Height;
	public float CornerRatio;
	public int Subdivisions;
	public bool bCanAcceptFailedResult;
	public bool bShowIntermediateResultOnFailure;
}
