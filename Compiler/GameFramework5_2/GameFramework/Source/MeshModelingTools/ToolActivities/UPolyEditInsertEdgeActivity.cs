#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Interactive activity for inserting a group edge into a mesh.</summary>
[CppInclude("ToolActivities/PolyEditInsertEdgeActivity.h")]
public partial class UPolyEditInsertEdgeActivity : UInteractiveToolActivity {
	///<summary>Settings</summary>
	public UGroupEdgeInsertionProperties Settings;
	///<summary>ActivityContext</summary>
	public UPolyEditActivityContext ActivityContext;
}
