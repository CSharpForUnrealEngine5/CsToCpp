#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Test structure for array properties.</summary>
public partial struct FStructSerializerArrayTestStruct {
// StructSerializerArrayTestStruct
	public TArray<int> Int32Array;
	public TArray<byte> ByteArray;
	public int StaticSingleElement;
	public int StaticInt32Array;
	public float StaticFloatArray;
	public TArray<FVector> VectorArray;
	public TArray<FStructSerializerBuiltinTestStruct> StructArray;
}
