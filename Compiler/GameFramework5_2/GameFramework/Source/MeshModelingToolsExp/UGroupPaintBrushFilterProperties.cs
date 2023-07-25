#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshGroupPaintTool.h")]
public partial class UGroupPaintBrushFilterProperties : UInteractiveToolPropertySet {
// GroupPaintBrushFilterProperties
	public EMeshGroupPaintBrushType PrimaryBrushType;
	public EMeshGroupPaintInteractionType SubToolType;
	public float BrushSize;
	public EMeshGroupPaintBrushAreaType BrushAreaMode;
	public bool bHitBackFaces;
	public int SetGroup;
	public bool bOnlySetUngrouped;
	public int EraseGroup;
	public bool bOnlyEraseCurrent;
	public float AngleThreshold;
	public bool bUVSeams;
	public bool bNormalSeams;
	public EMeshGroupPaintVisibilityType VisibilityFilter;
	public int MinTriVertCount;
	public bool bShowHitGroup;
	public bool bShowAllGroups;
}
