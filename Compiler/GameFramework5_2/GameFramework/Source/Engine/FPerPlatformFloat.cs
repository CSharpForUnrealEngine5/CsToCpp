#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PerPlatformProperties.h")]
///<summary>FPerPlatformFloat - float property with per-platform overrides</summary>
public partial struct FPerPlatformFloat {
// PerPlatformFloat
	public float Default;
	public TMap<string,float> PerPlatform;
}
