#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deletes several archived and/or live sessions.</summary>
[CppInclude("ConcertMessages.h")]
public partial struct FConcertAdmin_BatchDeleteSessionRequest {
	public TSet<FGuid> SessionIds;
	public EBatchSessionDeletionFlags Flags;
	public string UserName;
	public string DeviceName;
}
