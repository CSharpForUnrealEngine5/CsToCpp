#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The event message sent by the server to the client to perform the initial replication, sending</summary>
[CppInclude("ConcertDataStoreMessages.h")]
public partial struct FConcertDataStore_ReplicateEvent {
	public TArray<FConcertDataStore_KeyValuePair> Values;
}
