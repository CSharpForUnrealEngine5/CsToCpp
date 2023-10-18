namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for byte array properties.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerByteArray {
	public int Dummy1;
	public TArray<byte> ByteArray;
	public int Dummy2;
	public TArray<short> Int8Array;
	public int Dummy3;
}
