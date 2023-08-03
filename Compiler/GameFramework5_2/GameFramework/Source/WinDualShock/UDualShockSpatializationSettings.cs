#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WinDualShockSettings.h")]
public partial class UDualShockSpatializationSettings : USoundfieldEncodingSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Spread</summary>
	public float Spread;
	///<summary>Priority</summary>
	public int Priority;
	///<summary>Passthrough</summary>
	public bool Passthrough;
}
