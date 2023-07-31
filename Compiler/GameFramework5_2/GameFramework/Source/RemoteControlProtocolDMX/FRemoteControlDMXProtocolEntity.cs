#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DMX protocol entity for remote control binding</summary>
[CppInclude("RemoteControlProtocolDMX.h")]
public partial struct FRemoteControlDMXProtocolEntity {
	public FRemoteControlDMXProtocolEntityExtraSetting ExtraSetting;
	public uint RangeInputTemplate;
	public int Universe_DEPRECATED;
	public bool bUseLSB_DEPRECATED;
	public EDMXFixtureSignalFormat DataType_DEPRECATED;
	public bool bUseDefaultInputPort_DEPRECATED;
	public FGuid InputPortId_DEPRECATED;
}
