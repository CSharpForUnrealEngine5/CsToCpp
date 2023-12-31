namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectMixerEditorSerializedData.h")]
public partial struct FObjectMixerSerializationDataPerFilter {
	public FName FilterClassName;
	public TArray<FObjectMixerCollectionObjectSet> SerializedCollections;
	public TSet<FObjectMixerColumnData> SerializedColumnData;
}
