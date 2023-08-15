namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single tutorial stage, containing the optional main content &amp; a number of widgets with content attached</summary>
[CppInclude("EditorTutorial.h")]
public partial struct FTutorialStage {
	public FName Name;
	public FTutorialContent Content;
	public TArray<FTutorialWidgetContent> WidgetContent;
	public FText NextButtonText;
	public FText BackButtonText;
	public TArray<string> PlatformsToTest;
	public bool bInvertPlatformTest;
}
