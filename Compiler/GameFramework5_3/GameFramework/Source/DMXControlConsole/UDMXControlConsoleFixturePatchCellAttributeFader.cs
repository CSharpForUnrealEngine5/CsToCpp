namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A fader matching a Fixture Cell Attribute in the DMX Control Console.</summary>
[CppInclude("DMXControlConsoleFixturePatchCellAttributeFader.h")]
public partial class UDMXControlConsoleFixturePatchCellAttributeFader : UDMXControlConsoleFaderBase {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the attribute mapped to this Fader</summary>
	public FDMXAttributeName Attribute;
}
