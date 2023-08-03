#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/PlacementPlaceSingleTool.h")]
public partial class UPlacementModePlaceSingleToolSettings : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>How the cursor movement should apply to scale once an asset is placed. Note that the maximum bound is controlled by scale settings of the mode.</summary>
	public EPlacementScaleToCursorType ScalingType;
	///<summary>If the tool should automatically select the last placed asset.</summary>
	public bool bSelectAfterPlacing;
}
