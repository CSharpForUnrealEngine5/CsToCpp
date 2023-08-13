namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FPerPlatformInt - int32 property with per-platform overrides</summary>
[CppInclude("PerPlatformProperties.h")]
public partial struct FPerPlatformInt {
	public int Default;
	public TMap<string,int> PerPlatform;
}
