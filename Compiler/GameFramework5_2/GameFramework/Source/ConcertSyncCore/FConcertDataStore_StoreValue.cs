#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertDataStoreMessages.h")]
///<summary>A value and its meta-data as stored by a Concert data store and transported between a client and a server.</summary>
public partial struct FConcertDataStore_StoreValue {
// ConcertDataStore_StoreValue
	public string TypeName;
	public uint Version;
	public FConcertSessionSerializedPayload SerializedValue;
}
