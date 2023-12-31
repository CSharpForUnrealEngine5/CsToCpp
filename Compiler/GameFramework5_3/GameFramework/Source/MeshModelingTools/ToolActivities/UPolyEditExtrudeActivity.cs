namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditExtrudeActivity.h")]
public partial class UPolyEditExtrudeActivity : UInteractiveToolActivity {
	public static UClass StaticClass() {return default;}
	///<summary>ExtrudeProperties</summary>
	public UPolyEditExtrudeProperties ExtrudeProperties;
	///<summary>OffsetProperties</summary>
	public UPolyEditOffsetProperties OffsetProperties;
	///<summary>PushPullProperties</summary>
	public UPolyEditPushPullProperties PushPullProperties;
	///<summary>ExtrudeHeightMechanic</summary>
	public UPlaneDistanceFromHitMechanic ExtrudeHeightMechanic;
	///<summary>ActivityContext</summary>
	public UPolyEditActivityContext ActivityContext;
}
