namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Rivermax core plugin.</summary>
[CppInclude("RivermaxSettings.h")]
public partial class URivermaxSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Timing souce to be used by Rivermax scheduler</summary>
	public ERivermaxTimeSource TimeSource;
	///<summary>Interface to use when Rivermax timing is configured to use PTP</summary>
	public string PTPInterfaceAddress;
}
