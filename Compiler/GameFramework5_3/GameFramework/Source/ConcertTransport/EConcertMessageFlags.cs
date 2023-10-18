namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Message Flags when sent</summary>
public enum EConcertMessageFlags {
	None=0,
	ReliableOrdered=-1,
	UniqueId=-1,
}
