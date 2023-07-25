#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertDataStoreMessages.h")]
///<summary>The request passed from the client to the server to compare and exchange a stored value.</summary>
public partial struct FConcertDataStore_CompareExchangeRequest {
// ConcertDataStore_CompareExchangeRequest
	public uint ExpectedVersion;
	public FConcertSessionSerializedPayload Expected;
	public FConcertSessionSerializedPayload Desired;
}
