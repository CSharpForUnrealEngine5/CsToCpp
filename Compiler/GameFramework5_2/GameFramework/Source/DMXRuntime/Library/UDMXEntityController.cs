#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DEPRECATED 4.27, can&#39;t be flagged as such to retain upgrade path, some nodes could not be compiled anymore. All members are deprecated.</summary>
[CppInclude("Library/DMXEntityController.h")]
public partial class UDMXEntityController : UDMXEntityUniverseManaged {
	public static UClass StaticClass() {return default;}
	///<summary>CommunicationMode</summary>
	public EDMXCommunicationType CommunicationMode;
	///<summary>UniverseLocalStart</summary>
	public int UniverseLocalStart;
	///<summary>UniverseLocalNum</summary>
	public int UniverseLocalNum;
	///<summary>UniverseLocalEnd</summary>
	public int UniverseLocalEnd;
	///<summary>RemoteOffset</summary>
	public int RemoteOffset;
	///<summary>UniverseRemoteStart</summary>
	public int UniverseRemoteStart;
	///<summary>UniverseRemoteEnd</summary>
	public int UniverseRemoteEnd;
	///<summary>AdditionalUnicastIPs</summary>
	public TArray<string> AdditionalUnicastIPs;
}
