#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistryTypes.h")]
///<summary>Rules to use when deciding how to unload registry items and related assets</summary>
public partial struct FDataRegistryCachePolicy {
// DataRegistryCachePolicy
	public bool bCacheIsAlwaysVolatile;
	public bool bUseCurveTableCacheVersion;
	public int MinNumberKept;
	public int MaxNumberKept;
	public float ForceKeepSeconds;
	public float ForceReleaseSeconds;
}
