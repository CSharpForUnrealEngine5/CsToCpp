#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the polygon-on-mesh operations</summary>
[CppInclude("PolygonOnMeshTool.h")]
public partial class UPolygonOnMeshToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>What operation to apply using the Polygon</summary>
	public EEmbeddedPolygonOpMethod Operation;
	///<summary>Polygon Shape to use in this Operation</summary>
	public EPolygonType Shape;
	///<summary>Use a volumetric boolean rather than curve projection; cuts through all layers and across edges</summary>
	public bool bCutWithBoolean;
	///<summary>Automatically attempt to fill any open boundaries left by CSG (e.g. due to numerical errors)</summary>
	public bool bTryToFixHoles;
	///<summary>Scale of polygon to embed</summary>
	public float PolygonScale;
	///<summary>Width of Polygon</summary>
	public float Width;
	///<summary>Height of Polygon</summary>
	public float Height;
	///<summary>Corner Ratio of RoundRect Polygon</summary>
	public float CornerRatio;
	///<summary>Number of sides in Circle or RoundRect Corner</summary>
	public int Subdivisions;
	///<summary>Whether the tool will allow accepting a result if the operation fails, for instance due to inability to insert the</summary>
	public bool bCanAcceptFailedResult;
	///<summary>If an operation fails and we do not allow accepting the result, whether to show the intermediate failed result, or to</summary>
	public bool bShowIntermediateResultOnFailure;
}
