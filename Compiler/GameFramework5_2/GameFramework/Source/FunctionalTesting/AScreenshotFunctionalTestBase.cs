#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for screenshot functional test</summary>
[CppInclude("ScreenshotFunctionalTestBase.h")]
public partial class AScreenshotFunctionalTestBase : AFunctionalTest {
	public static UClass StaticClass() {return default;}
	///<summary>Notes</summary>
	public string Notes;
	///<summary>ScreenshotCamera</summary>
	public UCameraComponent ScreenshotCamera;
	///<summary>ScreenshotOptions</summary>
	public FAutomationScreenshotOptions ScreenshotOptions;
}
