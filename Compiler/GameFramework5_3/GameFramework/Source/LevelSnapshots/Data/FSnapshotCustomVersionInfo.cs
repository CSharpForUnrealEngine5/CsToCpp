namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds custom version information</summary>
[CppInclude("Data/SnapshotVersion.h")]
public partial struct FSnapshotCustomVersionInfo {
	public FName FriendlyName;
	public FGuid Key;
	public int Version;
}
