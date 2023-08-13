namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/CustomSerializationData.h")]
public partial struct FCustomSerializationData {
	public TArray<byte> RootAnnotationData;
	public TArray<FCustomSubbjectSerializationData> Subobjects;
}
