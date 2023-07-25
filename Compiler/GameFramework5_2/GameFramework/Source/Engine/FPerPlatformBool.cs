#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PerPlatformProperties.h")]
///<summary>FPerPlatformBool - bool property with per-platform overrides</summary>
public partial struct FPerPlatformBool {
// PerPlatformBool
	public bool Default;
	public TMap<string,bool> PerPlatform;
}
