#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Answer by server</summary>
public partial struct FConcertAdmin_BatchDeleteSessionResponse {
// ConcertAdmin_BatchDeleteSessionResponse
	public TArray<FDeletedSessionInfo> DeletedItems;
	public TArray<FDeletedSessionInfo> NotOwnedByClient;
}
