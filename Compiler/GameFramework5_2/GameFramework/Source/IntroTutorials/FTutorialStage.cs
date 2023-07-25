#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorial.h")]
///<summary>A single tutorial stage, containing the optional main content & a number of widgets with content attached</summary>
public partial struct FTutorialStage {
// TutorialStage
	public string Name;
	public FTutorialContent Content;
	public TArray<FTutorialWidgetContent> WidgetContent;
	public string NextButtonText;
	public string BackButtonText;
	public TArray<string> PlatformsToTest;
	public bool bInvertPlatformTest;
}
