namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertResourceLockRequest {
	public FGuid ClientId;
	public TArray<string> ResourceNames;
	public EConcertResourceLockType LockType;
}
