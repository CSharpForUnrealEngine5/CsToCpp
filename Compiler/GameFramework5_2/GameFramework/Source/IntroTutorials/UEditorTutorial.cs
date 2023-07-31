#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset used to build a stage-by-stage tutorial in the editor</summary>
[CppInclude("EditorTutorial.h")]
public partial class UEditorTutorial : UObject {
	///<summary>Title of this tutorial, used when presented to the user</summary>
	public string Title;
	///<summary>Sorting priority, used by the tutorial browser</summary>
	public int SortOrder;
	///<summary>Icon name for this tutorial, used when presented to the user in the tutorial browser. This is a name for the icon in the Slate editor style. Only used if there isn&#39;t a valid texture to use.</summary>
	public string Icon;
	///<summary>Texture for this tutorial, used when presented to the user in the tutorial browser.</summary>
	public UTexture2D Texture;
	///<summary>Category of this tutorial, used to organize tutorials when presented to the user</summary>
	public string Category;
	///<summary>Content to be displayed for this tutorial when presented to the user in summary</summary>
	public FTutorialContent SummaryContent;
	///<summary>The various stages of this tutorial</summary>
	public TArray<FTutorialStage> Stages;
	///<summary>Tutorial to optionally chain back to if the &quot;back&quot; button is clicked on the first stage</summary>
	public FSoftClassPath PreviousTutorial;
	///<summary>Tutorial to optionally chain onto after this tutorial completes</summary>
	public FSoftClassPath NextTutorial;
	///<summary>Attempts to find the actor specified by PathToActor in the current editor world</summary>
	public  AActor GetActorReference(string PathToActor) { return default; }
	///<summary>A standalone tutorial displays no navigation buttons and each content widget has a close button</summary>
	public bool bIsStandalone;
	///<summary>Asset to open &amp; attach the tutorial to. Non-widget-bound content will appear in the asset&#39;s window</summary>
	public FSoftObjectPath AssetToUse;
	///<summary>The path this tutorial was imported from, if any.</summary>
	public string ImportPath;
	///<summary>Hide this tutorial in the tutorials browser</summary>
	public bool bHideInBrowser;
	///<summary>Comma seperated list of tags the search will use to help find this tutorial</summary>
	public string SearchTags;
	///<summary>Event fired when a tutorial stage begins</summary>
	public  void OnTutorialStageStarted(string StageName) {}
	///<summary>Event fired when a tutorial stage ends</summary>
	public  void OnTutorialStageEnded(string StageName) {}
	///<summary>Event fired when a tutorial is launched</summary>
	public  void OnTutorialLaunched() {}
	///<summary>Event fired when a tutorial is closed</summary>
	public  void OnTutorialClosed() {}
	///<summary>Advance to the next stage of a tutorial</summary>
	public static void GoToNextTutorialStage() {}
	///<summary>Advance to the previous stage of a tutorial</summary>
	public static void GoToPreviousTutorialStage() {}
	///<summary>Begin a tutorial. Note that this will end the current tutorial that is in progress, if any</summary>
	public static void BeginTutorial(UEditorTutorial TutorialToStart,bool bRestart) {}
	///<summary>Open an asset for use by a tutorial</summary>
	public static void OpenAsset(UObject Asset) {}
	///<summary>Sets the visibility of the engine folder in the content browser</summary>
	public static void SetEngineFolderVisibilty(bool bNewVisibility) {}
	///<summary>Returns the visibility of the engine folder in the content browser</summary>
	public static bool GetEngineFolderVisibilty() { return default; }
}
