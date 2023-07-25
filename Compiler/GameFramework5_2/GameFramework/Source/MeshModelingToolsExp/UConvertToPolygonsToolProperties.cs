#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public partial class UConvertToPolygonsToolProperties : UInteractiveToolPropertySet {
// ConvertToPolygonsToolProperties
	public EConvertToPolygonsMode ConversionMode;
	public float AngleTolerance;
	public int NumPoints;
	public bool bSplitExisting;
	public bool bNormalWeighted;
	public float NormalWeighting;
	public float QuadAdjacencyWeight;
	public float QuadMetricClamp;
	public int QuadSearchRounds;
	public bool bRespectUVSeams;
	public bool bRespectHardNormals;
	public int MinGroupSize;
	public bool bCalculateNormals;
	public bool bShowGroupColors;
}
