namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for the various platform interface classes.</summary>
[CppInclude("Engine/CloudStorageBase.h")]
public partial class UCloudStorageBase : UPlatformInterfaceBase {
	public static UClass StaticClass() {return default;}
	///<summary>When using local storage (aka &quot;cloud emulation&quot;), this maintains a list of the file paths.</summary>
	public TArray<string> LocalCloudFiles;
	///<summary>If true, delegate callbacks should be skipped.</summary>
	public bool bSuppressDelegateCalls;
}
