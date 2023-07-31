#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A fader matching that sends Raw DMX</summary>
[CppInclude("DMXControlConsoleRawFader.h")]
public partial class UDMXControlConsoleRawFader : UDMXControlConsoleFaderBase {
	///<summary>The universe the should send to fader</summary>
	public int UniverseID;
	///<summary>The number of channels this Fader uses</summary>
	public EDMXFixtureSignalFormat DataType;
	///<summary>The starting channel Address to send DMX to</summary>
	public int StartingAddress;
	///<summary>Use Least Significant Byte mode. Individual bytes(channels) be interpreted with the first bytes being the lowest part of the number(endianness).</summary>
	public bool bUseLSBMode;
}
