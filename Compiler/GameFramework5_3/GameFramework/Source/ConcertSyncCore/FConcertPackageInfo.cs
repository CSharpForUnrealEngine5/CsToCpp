namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceData.h")]
public partial struct FConcertPackageInfo {
	public FName PackageName;
	public FName NewPackageName;
	public string AssetClass;
	public string PackageFileExtension;
	public EConcertPackageUpdateType PackageUpdateType;
	public long TransactionEventIdAtSave;
	public bool bPreSave;
	public bool bAutoSave;
}
