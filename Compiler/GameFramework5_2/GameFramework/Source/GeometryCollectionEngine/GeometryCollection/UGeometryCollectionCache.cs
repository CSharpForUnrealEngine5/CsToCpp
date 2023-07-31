#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionCache.h")]
public partial class UGeometryCollectionCache : UObject {
	///<summary>The recorded data from the simulation</summary>
	public FRecordedTransformTrack RecordedData;
	///<summary>The collection that we recorded the data from</summary>
	public UGeometryCollection SupportedCollection;
	///<summary>Guid pulled from the collection when the recording was last saved</summary>
	public FGuid CompatibleCollectionState;
}
