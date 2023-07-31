#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Rivermax core plugin.</summary>
[CppInclude("RivermaxSettings.h")]
public partial class URivermaxSettings : UDeveloperSettings {
	///<summary>Timing souce to be used by Rivermax scheduler</summary>
	public ERivermaxTimeSource TimeSource;
	///<summary>Interface to use when Rivermax timing is configured to use PTP</summary>
	public string PTPInterfaceAddress;
}
