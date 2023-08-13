namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditInsetOutsetActivity.h")]
public partial class UPolyEditInsetOutsetActivity : UInteractiveToolActivity {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UPolyEditInsetOutsetProperties Settings;
	///<summary>EditPreview</summary>
	public UPolyEditPreviewMesh EditPreview;
	///<summary>CurveDistMechanic</summary>
	public USpatialCurveDistanceMechanic CurveDistMechanic;
	///<summary>ActivityContext</summary>
	public UPolyEditActivityContext ActivityContext;
}
