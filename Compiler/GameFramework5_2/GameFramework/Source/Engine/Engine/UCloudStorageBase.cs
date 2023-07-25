#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CloudStorageBase.h")]
///<summary>Base class for the various platform interface classes.</summary>
public partial class UCloudStorageBase : UPlatformInterfaceBase {
// CloudStorageBase
	public TArray<string> LocalCloudFiles;
	public bool bSuppressDelegateCalls;
}
