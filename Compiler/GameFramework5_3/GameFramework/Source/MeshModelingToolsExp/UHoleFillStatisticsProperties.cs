namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HoleFillTool.h")]
public partial class UHoleFillStatisticsProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>InitialHoles</summary>
	public string InitialHoles;
	///<summary>SelectedHoles</summary>
	public string SelectedHoles;
	///<summary>SuccessfulFills</summary>
	public string SuccessfulFills;
	///<summary>FailedFills</summary>
	public string FailedFills;
	///<summary>RemainingHoles</summary>
	public string RemainingHoles;
}
