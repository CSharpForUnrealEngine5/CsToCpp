#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FPerPlatformFrameRate - FFrameRate property with per-platform overrides</summary>
[CppInclude("PerPlatformProperties.h")]
public partial struct FPerPlatformFrameRate {
	public FFrameRate Default;
	public TMap<string,FFrameRate> PerPlatform;
}
