#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamNetConnection.h")]
public partial class USteamNetConnection : UIpConnection {
	public static UClass StaticClass() {return default;}
	///<summary>Is this net connection passthrough to IpConnection</summary>
	public bool bIsPassthrough;
}
