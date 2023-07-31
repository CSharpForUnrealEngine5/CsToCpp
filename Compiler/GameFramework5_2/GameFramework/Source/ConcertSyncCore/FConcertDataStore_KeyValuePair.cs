#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains a key and its value, used by the client/server cache replication mechanism.</summary>
[CppInclude("ConcertDataStoreMessages.h")]
public partial struct FConcertDataStore_KeyValuePair {
	public string Key;
	public FConcertDataStore_StoreValue Value;
}
