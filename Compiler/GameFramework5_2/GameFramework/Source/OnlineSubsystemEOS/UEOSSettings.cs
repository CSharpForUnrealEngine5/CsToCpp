#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EOSSettings.h")]
public partial class UEOSSettings : URuntimeOptionsBase {
// EOSSettings
	public string CacheDir;
	public string DefaultArtifactName;
	public int TickBudgetInMilliseconds;
	public bool bEnableOverlay;
	public bool bEnableSocialOverlay;
	public bool bEnableEditorOverlay;
	public bool bShouldEnforceBeingLaunchedByEGS;
	public TArray<string> TitleStorageTags;
	public int TitleStorageReadChunkLength;
	public TArray<FArtifactSettings> Artifacts;
	public TArray<string> AuthScopeFlags;
	public bool bUseEAS;
	public bool bUseEOSConnect;
	public bool bMirrorStatsToEOS;
	public bool bMirrorAchievementsToEOS;
	public bool bUseEOSSessions;
	public bool bMirrorPresenceToEAS;
}
