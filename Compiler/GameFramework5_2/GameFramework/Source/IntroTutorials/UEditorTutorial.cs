#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorial.h")]
///<summary>An asset used to build a stage-by-stage tutorial in the editor</summary>
public partial class UEditorTutorial : UObject {
// EditorTutorial
	public string Title;
	public int SortOrder;
	public string Icon;
	public UTexture2D Texture;
	public string Category;
	public FTutorialContent SummaryContent;
	public TArray<FTutorialStage> Stages;
	public FSoftClassPath PreviousTutorial;
	public FSoftClassPath NextTutorial;
	public  AActor GetActorReference(string PathToActor) { return default; }
	public bool bIsStandalone;
	public FSoftObjectPath AssetToUse;
	public string ImportPath;
	public bool bHideInBrowser;
	public string SearchTags;
	public  void OnTutorialStageStarted(string StageName) {}
	public  void OnTutorialStageEnded(string StageName) {}
	public  void OnTutorialLaunched() {}
	public  void OnTutorialClosed() {}
	public static void GoToNextTutorialStage() {}
	public static void GoToPreviousTutorialStage() {}
	public static void BeginTutorial(UEditorTutorial TutorialToStart,bool bRestart) {}
	public static void OpenAsset(UObject Asset) {}
	public static void SetEngineFolderVisibilty(bool bNewVisibility) {}
	public static bool GetEngineFolderVisibilty() { return default; }
}
