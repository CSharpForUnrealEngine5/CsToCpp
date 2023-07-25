#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertMessages.h")]
///<summary>Deletes several archived and/or live sessions.</summary>
public partial struct FConcertAdmin_BatchDeleteSessionRequest {
// ConcertAdmin_BatchDeleteSessionRequest
	public TSet<FGuid> SessionIds;
	public EBatchSessionDeletionFlags Flags;
	public string UserName;
	public string DeviceName;
}
