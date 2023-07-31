#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectMixerEditorSerializedData.h")]
public partial struct FObjectMixerSerializationDataPerFilter {
	public string FilterClassName;
	public TArray<FObjectMixerCollectionObjectSet> SerializedCollections;
	public TSet<FObjectMixerColumnData> SerializedColumnData;
}
