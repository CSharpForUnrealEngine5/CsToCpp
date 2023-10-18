namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalUIScreenshotTest.h")]
public partial class AFunctionalUIScreenshotTest : AScreenshotFunctionalTestBase {
	public static UClass StaticClass() {return default;}
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
