namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data for a package event in a Concert Sync Session</summary>
[CppInclude("ConcertSyncSessionTypes.h")]
public partial struct FConcertSyncPackageEvent {
	public long PackageRevision;
	public FConcertPackage Package;
}
