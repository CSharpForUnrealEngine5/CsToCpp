namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class of any per platform settings.  The pattern for using these is as follows.</summary>
[CppInclude("Engine/PlatformSettings.h")]
public partial class UPlatformSettings : UObject {
	public static UClass StaticClass() {return default;}
}
