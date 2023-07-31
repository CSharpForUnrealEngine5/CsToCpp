#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The request passed from the client to the server to fetch or add a key/value pair</summary>
[CppInclude("ConcertDataStoreMessages.h")]
public partial struct FConcertDataStore_FetchOrAddRequest {
	public FConcertSessionSerializedPayload SerializedValue;
}
