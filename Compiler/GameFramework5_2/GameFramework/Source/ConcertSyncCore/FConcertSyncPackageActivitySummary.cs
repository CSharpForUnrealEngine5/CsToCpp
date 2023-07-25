#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSyncSessionTypes.h")]
///<summary>Summary for a package activity entry in a Concert Sync Session</summary>
public partial struct FConcertSyncPackageActivitySummary {
// ConcertSyncPackageActivitySummary
	public string PackageName;
	public string NewPackageName;
	public EConcertPackageUpdateType PackageUpdateType;
	public bool bAutoSave;
	public bool bPreSave;
}
