#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlProtocolDMX.h")]
///<summary>Using as an inner struct for details customization.</summary>
public partial struct FRemoteControlDMXProtocolEntityExtraSetting {
// RemoteControlDMXProtocolEntityExtraSetting
	public int Universe;
	public int StartingChannel;
	public bool bUseLSB;
	public EDMXFixtureSignalFormat DataType;
	public bool bUseDefaultInputPort;
	public FGuid InputPortId;
}
