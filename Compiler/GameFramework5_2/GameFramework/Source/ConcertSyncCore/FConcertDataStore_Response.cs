#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The response to a FConcertDataStore_FetchOrAddRequest or FConcertDataStore_CompareExchangeRequest requests, sent from the server to the client.</summary>
[CppInclude("ConcertDataStoreMessages.h")]
public partial struct FConcertDataStore_Response {
	public EConcertDataStoreResultCode ResultCode;
	public FConcertDataStore_StoreValue Value;
}
