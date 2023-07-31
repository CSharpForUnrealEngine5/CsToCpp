#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FPerPlatformBool - bool property with per-platform overrides</summary>
[CppInclude("PerPlatformProperties.h")]
public partial struct FPerPlatformBool {
	public bool Default;
	public TMap<string,bool> PerPlatform;
}
