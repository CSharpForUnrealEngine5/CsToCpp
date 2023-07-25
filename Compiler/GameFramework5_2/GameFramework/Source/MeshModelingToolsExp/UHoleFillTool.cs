#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HoleFillTool.h")]
///<summary>* Tool</summary>
public partial class UHoleFillTool : USingleSelectionMeshEditingTool {
// HoleFillTool
	public USmoothHoleFillProperties SmoothHoleFillProperties;
	public UHoleFillToolProperties Properties;
	public UHoleFillToolActions Actions;
	public UHoleFillStatisticsProperties Statistics;
	public UMeshOpPreviewWithBackgroundCompute Preview;
	public UBoundarySelectionMechanic SelectionMechanic;
}
