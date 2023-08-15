namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransactionEvents.h")]
public partial struct FConcertSerializedObjectData {
	public bool bAllowCreate;
	public bool bResetExisting;
	public bool bIsPendingKill;
	public FName NewPackageName;
	public FName NewName;
	public FName NewOuterPathName;
	public FName NewExternalPackageName;
	public TArray<byte> SerializedData;
}
