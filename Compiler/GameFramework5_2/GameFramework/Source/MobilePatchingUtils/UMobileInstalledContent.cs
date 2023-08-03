#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MobilePatchingLibrary.h")]
public partial class UMobileInstalledContent : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the disk free space in megabytes where content is installed</summary>
	public  float GetDiskFreeSpace() { return default; }
	///<summary>Get the installed content size in megabytes</summary>
	public  float GetInstalledContentSize() { return default; }
	///<summary>Mount installed content</summary>
	public  bool Mount(int PakOrder,string MountPoint) { return default; }
}
