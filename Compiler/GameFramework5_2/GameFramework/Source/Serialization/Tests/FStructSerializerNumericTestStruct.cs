#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for numeric properties.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerNumericTestStruct {
	public short Int8;
	public short Int16;
	public int Int32;
	public long Int64;
	public byte UInt8;
	public ushort UInt16;
	public uint UInt32;
	public ulong UInt64;
	public float Float;
	public double Double;
}
