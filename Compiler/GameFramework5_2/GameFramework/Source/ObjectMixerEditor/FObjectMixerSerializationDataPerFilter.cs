#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectMixerEditorSerializedData.h")]
public partial struct FObjectMixerSerializationDataPerFilter {
// ObjectMixerSerializationDataPerFilter
	public string FilterClassName;
	public TArray<FObjectMixerCollectionObjectSet> SerializedCollections;
	public TSet<FObjectMixerColumnData> SerializedColumnData;
}
