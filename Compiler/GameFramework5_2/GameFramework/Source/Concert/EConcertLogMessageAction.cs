namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportEvents.h")]
public enum EConcertLogMessageAction {
	None=0,
	Send=1,
	Publish=2,
	Receive=3,
	Queue=4,
	Discard=5,
	Duplicate=6,
	TimeOut=7,
	Process=8,
	EndpointDiscovery=9,
	EndpointTimeOut=10,
	EndpointClosure=11,
}
