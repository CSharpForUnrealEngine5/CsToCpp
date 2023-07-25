#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScreenshotFunctionalTestBase.h")]
///<summary>Base class for screenshot functional test</summary>
public partial class AScreenshotFunctionalTestBase : AFunctionalTest {
// ScreenshotFunctionalTestBase
	public string Notes;
	public UCameraComponent ScreenshotCamera;
	public FAutomationScreenshotOptions ScreenshotOptions;
}
