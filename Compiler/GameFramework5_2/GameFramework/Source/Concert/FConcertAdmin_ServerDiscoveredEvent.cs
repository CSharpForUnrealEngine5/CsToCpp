#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_ServerDiscoveredEvent {
	public string ServerName;
	public FConcertInstanceInfo InstanceInfo;
	public EConcertServerFlags ServerFlags;
}
