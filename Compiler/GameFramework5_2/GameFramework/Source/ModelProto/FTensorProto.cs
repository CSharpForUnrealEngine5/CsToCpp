#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelProto.h")]
///<summary>Level 6 - FTensorProto</summary>
public partial struct FTensorProto {
// TensorProto
	public TArray<long> Dimensions;
	public ETensorProtoDataType DataType;
	public FTensorProtoSegment Segment;
	public TArray<float> FloatData;
	public TArray<int> Int32Data;
	public TArray<string> StringData;
	public TArray<long> Int64Data;
	public string Name;
	public string DocString;
	public TArray<byte> RawData;
	public TArray<FStringStringEntryProto> ExternalData;
	public ETensorProtoDataLocation DataLocation;
	public TArray<double> DoubleData;
	public TArray<ulong> UInt64Data;
}
