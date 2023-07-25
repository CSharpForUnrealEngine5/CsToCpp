#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlProtocolDMX.h")]
///<summary>DMX protocol entity for remote control binding</summary>
public partial struct FRemoteControlDMXProtocolEntity {
// RemoteControlDMXProtocolEntity
	public FRemoteControlDMXProtocolEntityExtraSetting ExtraSetting;
	public uint RangeInputTemplate;
	public int Universe_DEPRECATED;
	public bool bUseLSB_DEPRECATED;
	public EDMXFixtureSignalFormat DataType_DEPRECATED;
	public bool bUseDefaultInputPort_DEPRECATED;
	public FGuid InputPortId_DEPRECATED;
}
