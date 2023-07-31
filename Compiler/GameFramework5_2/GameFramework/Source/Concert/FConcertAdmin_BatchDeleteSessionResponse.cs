#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Answer by server</summary>
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_BatchDeleteSessionResponse {
	public TArray<FDeletedSessionInfo> DeletedItems;
	public TArray<FDeletedSessionInfo> NotOwnedByClient;
}
