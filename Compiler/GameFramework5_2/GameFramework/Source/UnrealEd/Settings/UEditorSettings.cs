#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorSettings.h")]
public partial class UEditorSettings : UObject {
// EditorSettings
	public FDirectoryPath GlobalLocalDDCPath;
	public FDirectoryPath GlobalSharedDDCPath;
	public FDirectoryPath LocalDerivedDataCache;
	public FDirectoryPath SharedDerivedDataCache;
	public bool bEnableDDCNotifications;
	public bool bNotifyUseUnrealCloudDDC;
	public bool bNotifySetupDDCPath;
	public bool bNotifyEnableS3DD;
	public bool bEnableS3DDC;
	public FDirectoryPath GlobalS3DDCPath;
	public bool bLoadTheMostRecentlyLoadedProjectAtStartup;
	public bool bEditorAnalyticsEnabled_DEPRECATED;
	public TArray<FRecentProjectFile> RecentlyOpenedProjectFiles;
	public TArray<string> CreatedProjectPaths;
	public bool bCopyStarterContentPreference;
	public TArray<FGuid> CompletedSurveys;
	public TArray<FGuid> InProgressSurveys;
	public float AutoScalabilityWorkScaleAmount;
}
