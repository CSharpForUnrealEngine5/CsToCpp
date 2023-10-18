namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorSettings.h")]
public partial class UEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Adjusts the Local Cache location. This affects every project on your computer that uses the UE-LocalDataCachePath environment environment variable override.</summary>
	public FDirectoryPath GlobalLocalDDCPath;
	///<summary>Adjusts the Shared cache location. This affects every project on your computer that uses the UE-SharedDataCachePath environment variable override.</summary>
	public FDirectoryPath GlobalSharedDDCPath;
	///<summary>Project specific overide for the Local Cache location. The editor must be restarted for changes to take effect.</summary>
	public FDirectoryPath LocalDerivedDataCache;
	///<summary>Project specific overide for the Shared Cache location. The editor must be restarted for changes to take effect.</summary>
	public FDirectoryPath SharedDerivedDataCache;
	///<summary>Whether to enable any DDC Notifications</summary>
	public bool bEnableDDCNotifications;
	///<summary>Whether to enable the Unreal Cloud DDC notification</summary>
	public bool bNotifyUseUnrealCloudDDC;
	///<summary>Whether to enable the DDC path notification</summary>
	public bool bNotifySetupDDCPath;
	///<summary>Whether to enable the DDC path notification</summary>
	public bool bNotifyEnableS3DD;
	///<summary>Whether to enable the S3 derived data cache backend</summary>
	public bool bEnableS3DDC;
	///<summary>Adjusts the Local Cache location for AWS/S3 downloaded package bundles.</summary>
	public FDirectoryPath GlobalS3DDCPath;
	///<summary>When checked, the most recently loaded project will be auto-loaded at editor startup if no other project was specified on the command line</summary>
	public bool bLoadTheMostRecentlyLoadedProjectAtStartup;
	///<summary>Game project files that were recently opened in the editor</summary>
	public TArray<FRecentProjectFile> RecentlyOpenedProjectFiles;
	///<summary>The paths of projects created with the new project wizard. This is used to populate the &quot;Path&quot; field of the new project dialog.</summary>
	public TArray<string> CreatedProjectPaths;
	///<summary>bCopyStarterContentPreference</summary>
	public bool bCopyStarterContentPreference;
	///<summary>The id&#39;s of the surveys completed</summary>
	public TArray<FGuid> CompletedSurveys;
	///<summary>The id&#39;s of the surveys currently in-progress</summary>
	public TArray<FGuid> InProgressSurveys;
	///<summary>AutoScalabilityWorkScaleAmount</summary>
	public float AutoScalabilityWorkScaleAmount;
}
