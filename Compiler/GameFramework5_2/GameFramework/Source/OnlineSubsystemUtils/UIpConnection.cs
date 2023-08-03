#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IpConnection.h")]
public partial class UIpConnection : UNetConnection {
	public static UClass StaticClass() {return default;}
	///<summary>Instead of disconnecting immediately on a socket error, wait for some time to see if we can recover. Specified in Seconds.</summary>
	public float SocketErrorDisconnectDelay;
}
