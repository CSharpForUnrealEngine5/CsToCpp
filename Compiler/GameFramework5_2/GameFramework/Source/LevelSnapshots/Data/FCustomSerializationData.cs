#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/CustomSerializationData.h")]
public partial struct FCustomSerializationData {
// CustomSerializationData
	public TArray<byte> RootAnnotationData;
	public TArray<FCustomSubbjectSerializationData> Subobjects;
}
