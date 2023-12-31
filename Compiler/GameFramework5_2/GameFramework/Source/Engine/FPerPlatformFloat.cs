namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FPerPlatformFloat - float property with per-platform overrides</summary>
[CppInclude("PerPlatformProperties.h")]
public partial struct FPerPlatformFloat {
	public float Default;
	public TMap<FName,float> PerPlatform;
}
