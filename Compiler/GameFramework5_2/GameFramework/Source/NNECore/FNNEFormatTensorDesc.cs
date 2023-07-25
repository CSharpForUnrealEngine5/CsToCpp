#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NNECoreRuntimeFormat.h")]
public partial struct FNNEFormatTensorDesc {
// NNEFormatTensorDesc
	public string Name;
	public TArray<int> Shape;
	public ENNEFormatTensorType Type;
	public ENNETensorDataType DataType;
	public ulong DataSize;
	public ulong DataOffset;
}
