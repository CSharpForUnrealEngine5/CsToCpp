#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Using as an inner struct for details customization.</summary>
[CppInclude("RemoteControlProtocolDMX.h")]
public partial struct FRemoteControlDMXProtocolEntityExtraSetting {
	public int Universe;
	public int StartingChannel;
	public bool bUseLSB;
	public EDMXFixtureSignalFormat DataType;
	public bool bUseDefaultInputPort;
	public FGuid InputPortId;
}
