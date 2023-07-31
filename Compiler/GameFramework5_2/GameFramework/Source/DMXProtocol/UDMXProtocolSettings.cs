#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DMX Project Settings.</summary>
[CppInclude("DMXProtocolSettings.h")]
public partial class UDMXProtocolSettings : UObject {
	///<summary>DMX Input Port Configs</summary>
	public TArray<FDMXInputPortConfig> InputPortConfigs;
	///<summary>DMX Output Port Configs</summary>
	public TArray<FDMXOutputPortConfig> OutputPortConfigs;
	///<summary>Rate at which DMX is sent, in Hz from 1 to 1000. 44Hz is recommended.</summary>
	public uint SendingRefreshRate;
	///<summary>Rate at which DMX is received, in Hz from 1 to 1000. 44Hz is recommended</summary>
	public uint ReceivingRefreshRate_DEPRECATED;
	///<summary>Fixture Categories ENum</summary>
	public TSet<string> FixtureCategories;
	///<summary>Common names to map Fixture Functions to and access them easily on Blueprints</summary>
	public TSet<FDMXAttribute> Attributes;
	///<summary>Whether DMX is sent to the network. Recalled whenever editor or game starts.</summary>
	public bool bDefaultSendDMXEnabled;
	///<summary>Whether DMX is received from the network. Recalled whenever editor or game starts.</summary>
	public bool bDefaultReceiveDMXEnabled;
	///<summary>If true, all fixture patches receive DMX in Editor. This overrides the fixture patches &#39;Receive DMX In Editor&#39; property.</summary>
	public bool bAllFixturePatchesReceiveDMXInEditor;
	///<summary>InterfaceIPAddress_DEPRECATED</summary>
	public string InterfaceIPAddress_DEPRECATED;
	///<summary>GlobalArtNetUniverseOffset_DEPRECATED</summary>
	public int GlobalArtNetUniverseOffset_DEPRECATED;
	///<summary>GlobalSACNUniverseOffset_DEPRECATED</summary>
	public int GlobalSACNUniverseOffset_DEPRECATED;
}
