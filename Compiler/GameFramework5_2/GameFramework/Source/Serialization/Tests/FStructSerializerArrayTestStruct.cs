#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for array properties.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerArrayTestStruct {
	public TArray<int> Int32Array;
	public TArray<byte> ByteArray;
	public int StaticSingleElement;
	public int StaticInt32Array;
	public float StaticFloatArray;
	public TArray<FVector> VectorArray;
	public TArray<FStructSerializerBuiltinTestStruct> StructArray;
}
