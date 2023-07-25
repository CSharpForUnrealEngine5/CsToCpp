#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MQTTShared.h")]
///<summary>mqtt[s]:[username][:password]@host.domain[:port]</summary>
public partial struct FMQTTURL {
// MQTTURL
	public string Host;
	public int Port;
	public string Username;
	public string Password;
	public EMQTTScheme Scheme;
}
