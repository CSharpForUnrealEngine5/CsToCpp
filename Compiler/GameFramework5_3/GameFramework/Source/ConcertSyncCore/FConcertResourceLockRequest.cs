namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertResourceLockRequest {
	public FGuid ClientId;
	public TArray<FName> ResourceNames;
	public EConcertResourceLockType LockType;
}
