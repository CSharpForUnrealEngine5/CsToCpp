#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertDataStoreMessages.h")]
///<summary>Contains a key and its value, used by the client/server cache replication mechanism.</summary>
public partial struct FConcertDataStore_KeyValuePair {
// ConcertDataStore_KeyValuePair
	public string Key;
	public FConcertDataStore_StoreValue Value;
}
