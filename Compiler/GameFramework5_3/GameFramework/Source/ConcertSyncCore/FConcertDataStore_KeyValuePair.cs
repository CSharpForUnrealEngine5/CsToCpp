namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains a key and its value, used by the client/server cache replication mechanism.</summary>
[CppInclude("ConcertDataStoreMessages.h")]
public partial struct FConcertDataStore_KeyValuePair {
	public FName Key;
	public FConcertDataStore_StoreValue Value;
}
