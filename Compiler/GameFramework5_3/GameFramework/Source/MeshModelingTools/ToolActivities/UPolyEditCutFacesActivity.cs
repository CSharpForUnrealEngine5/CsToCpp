namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditCutFacesActivity.h")]
public partial class UPolyEditCutFacesActivity : UInteractiveToolActivity {
	public static UClass StaticClass() {return default;}
	///<summary>CutProperties</summary>
	public UPolyEditCutProperties CutProperties;
	///<summary>EditPreview</summary>
	public UPolyEditPreviewMesh EditPreview;
	///<summary>SurfacePathMechanic</summary>
	public UCollectSurfacePathMechanic SurfacePathMechanic;
	///<summary>ActivityContext</summary>
	public UPolyEditActivityContext ActivityContext;
}
