namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertResourceLockResponse {
	public TMap<string,FGuid> FailedResources;
	public EConcertResourceLockType LockType;
}
