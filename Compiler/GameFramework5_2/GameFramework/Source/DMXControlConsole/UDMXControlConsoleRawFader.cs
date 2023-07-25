#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXControlConsoleRawFader.h")]
///<summary>A fader matching that sends Raw DMX</summary>
public partial class UDMXControlConsoleRawFader : UDMXControlConsoleFaderBase {
// DMXControlConsoleRawFader
	public int UniverseID;
	public EDMXFixtureSignalFormat DataType;
	public int StartingAddress;
	public bool bUseLSBMode;
}
