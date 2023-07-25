#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertResourceLockResponse {
// ConcertResourceLockResponse
	public TMap<string,FGuid> FailedResources;
	public EConcertResourceLockType LockType;
}
