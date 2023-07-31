#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
