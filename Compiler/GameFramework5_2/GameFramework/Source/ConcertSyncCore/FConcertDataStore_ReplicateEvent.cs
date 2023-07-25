#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertDataStoreMessages.h")]
///<summary>The event message sent by the server to the client to perform the initial replication, sending</summary>
public partial struct FConcertDataStore_ReplicateEvent {
// ConcertDataStore_ReplicateEvent
	public TArray<FConcertDataStore_KeyValuePair> Values;
}
