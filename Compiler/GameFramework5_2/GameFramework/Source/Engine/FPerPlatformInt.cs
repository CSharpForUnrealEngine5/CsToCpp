#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PerPlatformProperties.h")]
///<summary>FPerPlatformInt - int32 property with per-platform overrides</summary>
public partial struct FPerPlatformInt {
// PerPlatformInt
	public int Default;
	public TMap<string,int> PerPlatform;
}
