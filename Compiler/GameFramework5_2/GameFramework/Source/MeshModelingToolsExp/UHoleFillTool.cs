#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Tool</summary>
[CppInclude("HoleFillTool.h")]
public partial class UHoleFillTool : USingleSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>SmoothHoleFillProperties</summary>
	public USmoothHoleFillProperties SmoothHoleFillProperties;
	///<summary>Properties</summary>
	public UHoleFillToolProperties Properties;
	///<summary>Actions</summary>
	public UHoleFillToolActions Actions;
	///<summary>Statistics</summary>
	public UHoleFillStatisticsProperties Statistics;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>SelectionMechanic</summary>
	public UBoundarySelectionMechanic SelectionMechanic;
}
