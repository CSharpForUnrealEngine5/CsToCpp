#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single tutorial stage, containing the optional main content &amp; a number of widgets with content attached</summary>
[CppInclude("EditorTutorial.h")]
public partial struct FTutorialStage {
	public string Name;
	public FTutorialContent Content;
	public TArray<FTutorialWidgetContent> WidgetContent;
	public string NextButtonText;
	public string BackButtonText;
	public TArray<string> PlatformsToTest;
	public bool bInvertPlatformTest;
}
