namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interactive activity for inserting (group) edge loops into a mesh.</summary>
[CppInclude("ToolActivities/PolyEditInsertEdgeLoopActivity.h")]
public partial class UPolyEditInsertEdgeLoopActivity : UInteractiveToolActivity {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UEdgeLoopInsertionProperties Settings;
	///<summary>ActivityContext</summary>
	public UPolyEditActivityContext ActivityContext;
}
