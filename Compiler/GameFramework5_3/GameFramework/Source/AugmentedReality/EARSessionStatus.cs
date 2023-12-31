namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>Describes the current status of the AR session.</summary>
public enum EARSessionStatus {
	NotStarted=0,
	Running=1,
	NotSupported=2,
	FatalError=3,
	PermissionNotGranted=4,
	UnsupportedConfiguration=5,
	Other=6,
}
