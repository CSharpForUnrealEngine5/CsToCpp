namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditPlanarProjectionUVActivity.h")]
public partial class UPolyEditPlanarProjectionUVActivity : UInteractiveToolActivity {
	public static UClass StaticClass() {return default;}
	///<summary>SetUVProperties</summary>
	public UPolyEditSetUVProperties SetUVProperties;
	///<summary>EditPreview</summary>
	public UPolyEditPreviewMesh EditPreview;
	///<summary>SurfacePathMechanic</summary>
	public UCollectSurfacePathMechanic SurfacePathMechanic;
	///<summary>ActivityContext</summary>
	public UPolyEditActivityContext ActivityContext;
}
