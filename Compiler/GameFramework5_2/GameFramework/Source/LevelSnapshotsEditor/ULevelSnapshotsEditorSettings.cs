#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotsEditorSettings.h")]
public partial class ULevelSnapshotsEditorSettings : UObject {
	///<summary>ParseLevelSnapshotsTokensInText</summary>
	public static string ParseLevelSnapshotsTokensInText(string InTextToParse,string InWorldName) { return default; }
	///<summary>The base directory in which all snapshots will be saved. LevelSnapshotSaveDir specifies in which subdirectory snapshots are saved.</summary>
	public FDirectoryPath RootLevelSnapshotSaveDir;
	///<summary>The format to use for the resulting filename. Extension will be added automatically. Any tokens of the form {token} will be replaced with the corresponding value:</summary>
	public string LevelSnapshotSaveDir;
	///<summary>The format to use for the resulting filename. Extension will be added automatically. Any tokens of the form {token} will be replaced with the corresponding value:</summary>
	public string DefaultLevelSnapshotName;
	///<summary>bEnableLevelSnapshotsToolbarButton</summary>
	public bool bEnableLevelSnapshotsToolbarButton;
	///<summary>bUseCreationForm</summary>
	public bool bUseCreationForm;
	///<summary>If true, clicking on an actor group under &#39;Modified Actors&#39; will select the actor in the scene. The previous selection will be deselected.</summary>
	public bool bClickActorGroupToSelectActorInScene;
	///<summary>PreferredCreationFormWindowWidth</summary>
	public float PreferredCreationFormWindowWidth;
	///<summary>PreferredCreationFormWindowHeight</summary>
	public float PreferredCreationFormWindowHeight;
}
