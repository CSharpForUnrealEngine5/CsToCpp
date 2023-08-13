namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for all concert request response messages</summary>
[CppInclude("ConcertTransportMessages.h")]
public partial struct FConcertResponseData {
	public FGuid RequestMessageId;
	public EConcertResponseCode ResponseCode;
	public FText Reason;
}
