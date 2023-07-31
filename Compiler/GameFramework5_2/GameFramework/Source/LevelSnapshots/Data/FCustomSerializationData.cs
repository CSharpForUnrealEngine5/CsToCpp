#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/CustomSerializationData.h")]
public partial struct FCustomSerializationData {
	public TArray<byte> RootAnnotationData;
	public TArray<FCustomSubbjectSerializationData> Subobjects;
}
