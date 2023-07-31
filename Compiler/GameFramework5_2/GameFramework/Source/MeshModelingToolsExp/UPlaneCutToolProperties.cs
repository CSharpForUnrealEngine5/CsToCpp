#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the plane cut operation</summary>
[CppInclude("PlaneCutTool.h")]
public partial class UPlaneCutToolProperties : UInteractiveToolPropertySet {
	///<summary>If true, both halves of the cut are computed</summary>
	public bool bKeepBothHalves;
	///<summary>If keeping both halves, separate the two pieces by this amount</summary>
	public float SpacingBetweenHalves;
	///<summary>bShowPreview</summary>
	public bool bShowPreview;
	///<summary>If true, the cut surface is filled with simple planar hole fill surface(s)</summary>
	public bool bFillCutHole;
	///<summary>If true, will attempt to fill cut holes even if they&#39;re ill-formed (e.g. because they connect to pre-existing holes in the geometry)</summary>
	public bool bFillSpans;
}
