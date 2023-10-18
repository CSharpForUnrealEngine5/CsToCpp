namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionCache.h")]
public partial class UGeometryCollectionCache : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The recorded data from the simulation</summary>
	public FRecordedTransformTrack RecordedData;
	///<summary>The collection that we recorded the data from</summary>
	public UGeometryCollection SupportedCollection;
	///<summary>Guid pulled from the collection when the recording was last saved</summary>
	public FGuid CompatibleCollectionState;
}
