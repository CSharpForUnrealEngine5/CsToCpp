#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>No UI</summary>
[CppInclude("ScreenshotFunctionalTest.h")]
public partial class AScreenshotFunctionalTest : AScreenshotFunctionalTestBase {
	public static UClass StaticClass() {return default;}
	///<summary>Tests not relying on temporal effects can force a camera cut to flush stale data</summary>
	public bool bCameraCutOnScreenshotPrep;
}
