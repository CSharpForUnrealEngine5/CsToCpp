#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertResourceLockRequest {
// ConcertResourceLockRequest
	public FGuid ClientId;
	public TArray<string> ResourceNames;
	public EConcertResourceLockType LockType;
}
