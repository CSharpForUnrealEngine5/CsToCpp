namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/NetPing.h")]
///<summary>Flags specifying different types of ping.</summary>
public enum EPingType {
	None=0,
	RoundTrip=1,
	RoundTripExclFrame=2,
	ICMP=4,
	UDPQoS=8,
	Max=-1,
	Count=-1,
}
