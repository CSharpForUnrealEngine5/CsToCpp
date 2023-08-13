namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransactionEvents.h")]
public partial struct FConcertSerializedObjectData {
	public bool bAllowCreate;
	public bool bResetExisting;
	public bool bIsPendingKill;
	public string NewPackageName;
	public string NewName;
	public string NewOuterPathName;
	public string NewExternalPackageName;
	public TArray<byte> SerializedData;
}
