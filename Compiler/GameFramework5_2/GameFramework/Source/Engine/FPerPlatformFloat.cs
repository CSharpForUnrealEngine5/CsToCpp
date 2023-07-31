#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FPerPlatformFloat - float property with per-platform overrides</summary>
[CppInclude("PerPlatformProperties.h")]
public partial struct FPerPlatformFloat {
	public float Default;
	public TMap<string,float> PerPlatform;
}
