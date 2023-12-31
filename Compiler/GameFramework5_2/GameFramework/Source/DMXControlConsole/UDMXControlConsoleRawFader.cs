namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A fader matching that sends Raw DMX</summary>
[CppInclude("DMXControlConsoleRawFader.h")]
public partial class UDMXControlConsoleRawFader : UDMXControlConsoleFaderBase {
	public static UClass StaticClass() {return default;}
	///<summary>The universe the should send to fader</summary>
	public int UniverseID;
	///<summary>The number of channels this Fader uses</summary>
	public EDMXFixtureSignalFormat DataType;
	///<summary>The starting channel Address to send DMX to</summary>
	public int StartingAddress;
	///<summary>Use Least Significant Byte mode. Individual bytes(channels) be interpreted with the first bytes being the lowest part of the number(endianness).</summary>
	public bool bUseLSBMode;
}
