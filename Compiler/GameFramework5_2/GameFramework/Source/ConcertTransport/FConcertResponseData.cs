#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Base struct for all concert request response messages</summary>
public partial struct FConcertResponseData {
// ConcertResponseData
	public FGuid RequestMessageId;
	public EConcertResponseCode ResponseCode;
	public string Reason;
}
