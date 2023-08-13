namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A value and its meta-data as stored by a Concert data store and transported between a client and a server.</summary>
[CppInclude("ConcertDataStoreMessages.h")]
public partial struct FConcertDataStore_StoreValue {
	public string TypeName;
	public uint Version;
	public FConcertSessionSerializedPayload SerializedValue;
}
