namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransactionEvents.h")]
public partial struct FConcertExportedObject {
	public FConcertObjectId ObjectId;
	public int ObjectPathDepth;
	public FConcertSerializedObjectData ObjectData;
	public TArray<FConcertSerializedPropertyData> PropertyDatas;
	public TArray<byte> SerializedAnnotationData;
}
