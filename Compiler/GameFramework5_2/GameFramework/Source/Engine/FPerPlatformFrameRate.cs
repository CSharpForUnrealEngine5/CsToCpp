#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PerPlatformProperties.h")]
///<summary>FPerPlatformFrameRate - FFrameRate property with per-platform overrides</summary>
public partial struct FPerPlatformFrameRate {
// PerPlatformFrameRate
	public FFrameRate Default;
	public TMap<string,FFrameRate> PerPlatform;
}
