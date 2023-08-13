namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransactionEvents.h")]
public partial struct FConcertTransactionEventBase {
	public FGuid TransactionId;
	public FGuid OperationId;
	public FGuid TransactionEndpointId;
	public byte TransactionUpdateIndex;
	public int VersionIndex;
	public TArray<string> ModifiedPackages;
	public FConcertObjectId PrimaryObjectId;
	public TArray<FConcertExportedObject> ExportedObjects;
}
