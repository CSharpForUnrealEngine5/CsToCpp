#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EOSSettings.h")]
public partial class UEOSSettings : URuntimeOptionsBase {
	///<summary>The directory any PDS/TDS files are cached into. This is per artifact e.g.:</summary>
	public string CacheDir;
	///<summary>Used when launched from a store other than EGS or when the specified artifact name was not present</summary>
	public string DefaultArtifactName;
	///<summary>Used to throttle how much time EOS ticking can take</summary>
	public int TickBudgetInMilliseconds;
	///<summary>Set to true to enable the overlay (ecom features)</summary>
	public bool bEnableOverlay;
	///<summary>Set to true to enable the social overlay (friends, invites, etc.)</summary>
	public bool bEnableSocialOverlay;
	///<summary>Set to true to enable the overlay when running in the editor</summary>
	public bool bEnableEditorOverlay;
	///<summary>Set to true to enable the social overlay (friends, invites, etc.)</summary>
	public bool bShouldEnforceBeingLaunchedByEGS;
	///<summary>Tag combinations for paged queries in title file enumerations, separate tags within groups using `+`</summary>
	public TArray<string> TitleStorageTags;
	///<summary>Chunk size used when reading a title file</summary>
	public int TitleStorageReadChunkLength;
	///<summary>Per artifact SDK settings. A game might have a FooStaging, FooQA, and public Foo artifact</summary>
	public TArray<FArtifactSettings> Artifacts;
	///<summary>Auth scopes to request during login</summary>
	public TArray<string> AuthScopeFlags;
	///<summary>Set to true to have Epic Accounts used (friends list will be unified with the default platform)</summary>
	public bool bUseEAS;
	///<summary>Set to true to have EOS Connect APIs used to link accounts for crossplay</summary>
	public bool bUseEOSConnect;
	///<summary>Set to true to write stats to EOS as well as the default platform</summary>
	public bool bMirrorStatsToEOS;
	///<summary>Set to true to write achievement data to EOS as well as the default platform</summary>
	public bool bMirrorAchievementsToEOS;
	///<summary>Set to true to use EOS for session registration with data mirrored to the default platform</summary>
	public bool bUseEOSSessions;
	///<summary>Set to true to have Epic Accounts presence information updated when the default platform is updated</summary>
	public bool bMirrorPresenceToEAS;
}
