namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FPerPlatformBool - bool property with per-platform overrides</summary>
[CppInclude("PerPlatformProperties.h")]
public partial struct FPerPlatformBool {
	public bool Default;
	public TMap<FName,bool> PerPlatform;
}
