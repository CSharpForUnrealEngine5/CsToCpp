namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interactive activity for inserting a group edge into a mesh.</summary>
[CppInclude("ToolActivities/PolyEditInsertEdgeActivity.h")]
public partial class UPolyEditInsertEdgeActivity : UInteractiveToolActivity {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UGroupEdgeInsertionProperties Settings;
	///<summary>ActivityContext</summary>
	public UPolyEditActivityContext ActivityContext;
}
