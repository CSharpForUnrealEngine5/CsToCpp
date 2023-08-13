namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Identifies an media connection.</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOConnection {
	public FMediaIODevice Device;
	public string Protocol;
	public EMediaIOTransportType TransportType;
	public EMediaIOQuadLinkTransportType QuadTransportType;
	public int PortIdentifier;
}
