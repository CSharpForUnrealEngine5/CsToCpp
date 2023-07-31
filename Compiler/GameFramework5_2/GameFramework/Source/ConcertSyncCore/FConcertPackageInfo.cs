#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceData.h")]
public partial struct FConcertPackageInfo {
	public string PackageName;
	public string NewPackageName;
	public string AssetClass;
	public string PackageFileExtension;
	public EConcertPackageUpdateType PackageUpdateType;
	public long TransactionEventIdAtSave;
	public bool bPreSave;
	public bool bAutoSave;
}
