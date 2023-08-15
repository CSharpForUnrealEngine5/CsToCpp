namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FPerPlatformFrameRate - FFrameRate property with per-platform overrides</summary>
[CppInclude("PerPlatformProperties.h")]
public partial struct FPerPlatformFrameRate {
	public FFrameRate Default;
	public TMap<FName,FFrameRate> PerPlatform;
}
