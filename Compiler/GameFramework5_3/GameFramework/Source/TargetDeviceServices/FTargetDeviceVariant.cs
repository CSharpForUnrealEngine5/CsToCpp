namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for a flavor&#39;s information</summary>
[CppInclude("TargetDeviceServiceMessages.h")]
public partial struct FTargetDeviceVariant {
	public string DeviceID;
	public FName VariantName;
	public string TargetPlatformName;
	public FName TargetPlatformId;
	public FName VanillaPlatformId;
	public string PlatformDisplayName;
}
