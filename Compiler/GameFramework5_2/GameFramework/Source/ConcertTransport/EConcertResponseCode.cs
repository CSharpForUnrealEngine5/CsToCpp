namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Response codes to a sent request</summary>
public enum EConcertResponseCode {
	Pending=0,
	Success=1,
	Failed=2,
	InvalidRequest=3,
	UnknownRequest=4,
	TimedOut=5,
}
