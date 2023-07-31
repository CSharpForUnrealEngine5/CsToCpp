#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about an input device&#39;s current state</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FPlatformInputDeviceState {
	public FPlatformUserId OwningPlatformUser;
	public EInputDeviceConnectionState ConnectionState;
}
