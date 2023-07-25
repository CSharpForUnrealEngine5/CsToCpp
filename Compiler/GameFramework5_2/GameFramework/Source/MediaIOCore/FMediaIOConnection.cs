#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaIOCoreDefinitions.h")]
///<summary>Identifies an media connection.</summary>
public partial struct FMediaIOConnection {
// MediaIOConnection
	public FMediaIODevice Device;
	public string Protocol;
	public EMediaIOTransportType TransportType;
	public EMediaIOQuadLinkTransportType QuadTransportType;
	public int PortIdentifier;
}
