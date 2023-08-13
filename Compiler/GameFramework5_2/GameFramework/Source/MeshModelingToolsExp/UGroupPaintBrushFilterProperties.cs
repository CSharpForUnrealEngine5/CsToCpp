namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshGroupPaintTool.h")]
public partial class UGroupPaintBrushFilterProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Primary Brush Mode //UPROPERTY(EditAnywhere, Category = Brush2, meta = (DisplayName = &quot;Brush Type&quot;))</summary>
	public EMeshGroupPaintBrushType PrimaryBrushType;
	///<summary>SubToolType</summary>
	public EMeshGroupPaintInteractionType SubToolType;
	///<summary>Relative size of brush</summary>
	public float BrushSize;
	///<summary>When Volumetric, all faces inside the brush sphere are selected, otherwise only connected faces are selected</summary>
	public EMeshGroupPaintBrushAreaType BrushAreaMode;
	///<summary>Allow the Brush to hit the back-side of the mesh</summary>
	public bool bHitBackFaces;
	///<summary>The group that will be assigned to triangles</summary>
	public int SetGroup;
	///<summary>If true, only triangles with no group assigned will be painted</summary>
	public bool bOnlySetUngrouped;
	///<summary>Group to set as Erased value</summary>
	public int EraseGroup;
	///<summary>When enabled, only the current group configured in the Paint brush is erased</summary>
	public bool bOnlyEraseCurrent;
	///<summary>The Region affected by the current operation will be bounded by edge angles larger than this threshold</summary>
	public float AngleThreshold;
	///<summary>The Region affected by the current operation will be bounded by UV borders/seams</summary>
	public bool bUVSeams;
	///<summary>The Region affected by the current operation will be bounded by Hard Normal edges/seams</summary>
	public bool bNormalSeams;
	///<summary>Control which triangles can be affected by the current operation based on visibility. Applied after all other filters.</summary>
	public EMeshGroupPaintVisibilityType VisibilityFilter;
	///<summary>Number of vertices in a triangle the Lasso must hit to be counted as &quot;inside&quot;</summary>
	public int MinTriVertCount;
	///<summary>Display the Group ID of the last triangle under the cursor</summary>
	public bool bShowHitGroup;
	///<summary>Display the Group ID for all visible groups in the mesh</summary>
	public bool bShowAllGroups;
}
