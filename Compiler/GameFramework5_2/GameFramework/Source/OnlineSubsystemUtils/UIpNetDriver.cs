#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IpNetDriver.h")]
public partial class UIpNetDriver : UNetDriver {
// IpNetDriver
	public bool LogPortUnreach;
	public bool AllowPlayerPortUnreach;
	public uint MaxPortCountToTry;
	public uint ServerDesiredSocketReceiveBufferBytes;
	public uint ServerDesiredSocketSendBufferBytes;
	public uint ClientDesiredSocketReceiveBufferBytes;
	public uint ClientDesiredSocketSendBufferBytes;
	public double MaxSecondsInReceive;
	public int NbPacketsBetweenReceiveTimeTest;
	public float ResolutionConnectionTimeout;
}
