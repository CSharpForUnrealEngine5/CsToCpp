#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public partial class UConvertToPolygonsToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Strategy to use to group triangles</summary>
	public EConvertToPolygonsMode ConversionMode;
	///<summary>Tolerance for planarity</summary>
	public float AngleTolerance;
	///<summary>Furthest-Point Sample count, approximately this number of polygroups will be generated</summary>
	public int NumPoints;
	///<summary>If enabled, then furthest-point sampling happens with respect to existing Polygroups, ie the existing groups are further subdivided</summary>
	public bool bSplitExisting;
	///<summary>If true, region-growing in Sampling modes will be controlled by face normals, resulting in regions with borders that are more-aligned with curvature ridges</summary>
	public bool bNormalWeighted;
	///<summary>This parameter modulates the effect of normal weighting during region-growing</summary>
	public float NormalWeighting;
	///<summary>Bias for Quads that are adjacent to already-discovered Quads. Set to 0 to disable.</summary>
	public float QuadAdjacencyWeight;
	///<summary>Set to values below 1 to ignore less-likely triangle pairings</summary>
	public float QuadMetricClamp;
	///<summary>Iteratively repeat quad-searching in uncertain areas, to try to slightly improve results</summary>
	public int QuadSearchRounds;
	///<summary>If true, polygroup borders will not cross existing UV seams</summary>
	public bool bRespectUVSeams;
	///<summary>If true, polygroup borders will not cross existing hard normal seams</summary>
	public bool bRespectHardNormals;
	///<summary>group filtering</summary>
	public int MinGroupSize;
	///<summary>If true, normals are recomputed per-group, with hard edges at group boundaries</summary>
	public bool bCalculateNormals;
	///<summary>Display each group with a different auto-generated color</summary>
	public bool bShowGroupColors;
}
