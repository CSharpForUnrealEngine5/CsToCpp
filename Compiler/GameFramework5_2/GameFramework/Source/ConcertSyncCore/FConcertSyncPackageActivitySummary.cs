namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Summary for a package activity entry in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncPackageActivitySummary {
	public string PackageName;
	public string NewPackageName;
	public EConcertPackageUpdateType PackageUpdateType;
	public bool bAutoSave;
	public bool bPreSave;
}
