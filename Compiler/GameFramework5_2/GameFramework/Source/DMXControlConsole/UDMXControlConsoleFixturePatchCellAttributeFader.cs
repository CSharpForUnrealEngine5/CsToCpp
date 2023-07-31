#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A fader matching a Fixture Cell Attribute in the DMX Control Console.</summary>
[CppInclude("DMXControlConsoleFixturePatchCellAttributeFader.h")]
public partial class UDMXControlConsoleFixturePatchCellAttributeFader : UDMXControlConsoleFaderBase {
	///<summary>The universe DMX data should be send to</summary>
	public int UniverseID;
	///<summary>The starting channel Address to send DMX to</summary>
	public int StartingAddress;
	///<summary>Use Least Significant Byte mode. Individual bytes(channels) be interpreted with the first bytes being the lowest part of the number(endianness).</summary>
	public bool bUseLSBMode;
	///<summary>Name of the attribute mapped to this Fader</summary>
	public FDMXAttributeName Attribute;
}
