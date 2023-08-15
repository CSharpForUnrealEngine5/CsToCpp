namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Summary for a package activity entry in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncPackageActivitySummary {
	public FName PackageName;
	public FName NewPackageName;
	public EConcertPackageUpdateType PackageUpdateType;
	public bool bAutoSave;
	public bool bPreSave;
}
