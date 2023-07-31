#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalUIScreenshotTest.h")]
public partial class AFunctionalUIScreenshotTest : AScreenshotFunctionalTestBase {
	///<summary>WidgetClass</summary>
	public UClass WidgetClass;
	///<summary>SpawnedWidget</summary>
	public UUserWidget SpawnedWidget;
	///<summary>WidgetLocation</summary>
	public EWidgetTestAppearLocation WidgetLocation;
	///<summary>ScreenshotRT</summary>
	public UTextureRenderTarget2D ScreenshotRT;
	///<summary>bHideDebugCanvas</summary>
	public bool bHideDebugCanvas;
}
