namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamNetConnection.h")]
public partial class USteamNetConnection : UIpConnection {
	public static UClass StaticClass() {return default;}
	///<summary>Is this net connection passthrough to IpConnection</summary>
	public bool bIsPassthrough;
}
