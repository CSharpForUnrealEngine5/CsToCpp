#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXControlConsoleFixturePatchCellAttributeFader.h")]
///<summary>A fader matching a Fixture Cell Attribute in the DMX Control Console.</summary>
public partial class UDMXControlConsoleFixturePatchCellAttributeFader : UDMXControlConsoleFaderBase {
// DMXControlConsoleFixturePatchCellAttributeFader
	public int UniverseID;
	public int StartingAddress;
	public bool bUseLSBMode;
	public FDMXAttributeName Attribute;
}
