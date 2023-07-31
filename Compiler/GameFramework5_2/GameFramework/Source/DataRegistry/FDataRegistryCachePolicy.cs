#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rules to use when deciding how to unload registry items and related assets</summary>
[CppInclude("DataRegistryTypes.h")]
public partial struct FDataRegistryCachePolicy {
	public bool bCacheIsAlwaysVolatile;
	public bool bUseCurveTableCacheVersion;
	public int MinNumberKept;
	public int MaxNumberKept;
	public float ForceKeepSeconds;
	public float ForceReleaseSeconds;
}
