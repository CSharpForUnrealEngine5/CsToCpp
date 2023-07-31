#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectionTool.h")]
public enum EMeshSelectionToolActions {
	NoAction=0,
	SelectAll=1,
	SelectAllByMaterial=2,
	ClearSelection=3,
	InvertSelection=4,
	GrowSelection=5,
	ShrinkSelection=6,
	ExpandToConnected=7,
	SelectLargestComponentByTriCount=8,
	SelectLargestComponentByArea=9,
	OptimizeSelection=10,
	DeleteSelected=11,
	DisconnectSelected=12,
	SeparateSelected=13,
	DuplicateSelected=14,
	FlipSelected=15,
	CreateGroup=16,
	SmoothBoundary=17,
	CycleSelectionMode=18,
	CycleViewMode=19,
}
