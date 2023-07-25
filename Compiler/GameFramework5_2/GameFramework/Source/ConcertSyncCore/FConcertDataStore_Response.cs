#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertDataStoreMessages.h")]
///<summary>The response to a FConcertDataStore_FetchOrAddRequest or FConcertDataStore_CompareExchangeRequest requests, sent from the server to the client.</summary>
public partial struct FConcertDataStore_Response {
// ConcertDataStore_Response
	public EConcertDataStoreResultCode ResultCode;
	public FConcertDataStore_StoreValue Value;
}
