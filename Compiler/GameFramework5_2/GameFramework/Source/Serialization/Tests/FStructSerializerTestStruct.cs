#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for all supported types.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerTestStruct {
	public FStructSerializerNumericTestStruct Numerics;
	public FStructSerializerBooleanTestStruct Booleans;
	public FStructSerializerObjectTestStruct Objects;
	public FStructSerializerBuiltinTestStruct Builtins;
	public FStructSerializerArrayTestStruct Arrays;
	public FStructSerializerMapTestStruct Maps;
	public FStructSerializerSetTestStruct Sets;
	public FStructSerializerLWCTypesTest LWCTypes;
}
