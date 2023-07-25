#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXProtocolSettings.h")]
///<summary>DMX Project Settings.</summary>
public partial class UDMXProtocolSettings : UObject {
// DMXProtocolSettings
	public TArray<FDMXInputPortConfig> InputPortConfigs;
	public TArray<FDMXOutputPortConfig> OutputPortConfigs;
	public uint SendingRefreshRate;
	public uint ReceivingRefreshRate_DEPRECATED;
	public TSet<string> FixtureCategories;
	public TSet<FDMXAttribute> Attributes;
	public bool bDefaultSendDMXEnabled;
	public bool bDefaultReceiveDMXEnabled;
	public bool bAllFixturePatchesReceiveDMXInEditor;
	public string InterfaceIPAddress_DEPRECATED;
	public int GlobalArtNetUniverseOffset_DEPRECATED;
	public int GlobalSACNUniverseOffset_DEPRECATED;
}
