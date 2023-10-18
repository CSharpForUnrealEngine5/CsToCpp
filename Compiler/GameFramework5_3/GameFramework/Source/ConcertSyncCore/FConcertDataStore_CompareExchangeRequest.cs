namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The request passed from the client to the server to compare and exchange a stored value.</summary>
[CppInclude("ConcertDataStoreMessages.h")]
public partial struct FConcertDataStore_CompareExchangeRequest {
	public uint ExpectedVersion;
	public FConcertSessionSerializedPayload Expected;
	public FConcertSessionSerializedPayload Desired;
}
