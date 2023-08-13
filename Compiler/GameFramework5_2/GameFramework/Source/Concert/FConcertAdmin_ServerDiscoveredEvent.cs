namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_ServerDiscoveredEvent {
	public string ServerName;
	public FConcertInstanceInfo InstanceInfo;
	public EConcertServerFlags ServerFlags;
}
