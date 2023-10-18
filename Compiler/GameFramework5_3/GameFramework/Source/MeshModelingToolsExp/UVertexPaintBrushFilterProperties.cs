namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintTool.h")]
public partial class UVertexPaintBrushFilterProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Area Mode specifies the shape of the brush and which triangles will be included relative to the cursor</summary>
	public EMeshVertexPaintBrushAreaType BrushAreaMode;
	///<summary>The Region affected by the current operation will be bounded by edge angles larger than this threshold</summary>
	public float AngleThreshold;
	///<summary>The Region affected by the current operation will be bounded by UV borders/seams</summary>
	public bool bUVSeams;
	///<summary>The Region affected by the current operation will be bounded by Hard Normal edges/seams</summary>
	public bool bNormalSeams;
	///<summary>Control which triangles can be affected by the current operation based on visibility. Applied after all other filters.</summary>
	public EMeshVertexPaintVisibilityType VisibilityFilter;
	///<summary>Number of vertices in a triangle the Lasso must hit to be counted as &quot;inside&quot; //UPROPERTY(EditAnywhere, Category = Filters, AdvancedDisplay, meta = (UIMin = 1, UIMax = 3, EditCondition = &quot;CurrentSubToolType == EMeshVertexPaintInteractionType::PolyLasso&quot;))</summary>
	public int MinTriVertCount;
	///<summary>Specify which Materials should be used to render the Mesh</summary>
	public EMeshVertexPaintMaterialMode MaterialMode;
	///<summary>Display the Color under the cursor</summary>
	public bool bShowHitColor;
	///<summary>values below are for edit conditions and track the current BasicProperties setting</summary>
	public EMeshVertexPaintInteractionType CurrentSubToolType;
}
