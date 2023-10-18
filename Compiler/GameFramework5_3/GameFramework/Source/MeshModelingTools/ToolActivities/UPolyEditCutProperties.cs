namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditCutFacesActivity.h")]
public partial class UPolyEditCutProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Orientation</summary>
	public EPolyEditCutPlaneOrientation Orientation;
	///<summary>bSnapToVertices</summary>
	public bool bSnapToVertices;
}
