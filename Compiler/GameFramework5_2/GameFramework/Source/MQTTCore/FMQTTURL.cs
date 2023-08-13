namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>mqtt[s]:[username][:password]@host.domain[:port]</summary>
[CppInclude("MQTTShared.h")]
public partial struct FMQTTURL {
	public string Host;
	public int Port;
	public string Username;
	public string Password;
	public EMQTTScheme Scheme;
}
