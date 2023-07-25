#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXEntityController.h")]
///<summary>DEPRECATED 4.27, can't be flagged as such to retain upgrade path, some nodes could not be compiled anymore. All members are deprecated.</summary>
public partial class UDMXEntityController : UDMXEntityUniverseManaged {
// DMXEntityController
	public EDMXCommunicationType CommunicationMode;
	public int UniverseLocalStart;
	public int UniverseLocalNum;
	public int UniverseLocalEnd;
	public int RemoteOffset;
	public int UniverseRemoteStart;
	public int UniverseRemoteEnd;
	public TArray<string> AdditionalUnicastIPs;
}
