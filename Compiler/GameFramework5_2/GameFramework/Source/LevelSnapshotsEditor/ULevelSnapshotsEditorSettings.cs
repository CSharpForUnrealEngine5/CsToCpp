#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotsEditorSettings.h")]
public partial class ULevelSnapshotsEditorSettings : UObject {
// LevelSnapshotsEditorSettings
	public static string ParseLevelSnapshotsTokensInText(string InTextToParse,string InWorldName) { return default; }
	public FDirectoryPath RootLevelSnapshotSaveDir;
	public string LevelSnapshotSaveDir;
	public string DefaultLevelSnapshotName;
	public bool bEnableLevelSnapshotsToolbarButton;
	public bool bUseCreationForm;
	public bool bClickActorGroupToSelectActorInScene;
	public float PreferredCreationFormWindowWidth;
	public float PreferredCreationFormWindowHeight;
}
