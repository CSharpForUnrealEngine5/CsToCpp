#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Test structure for all supported types.</summary>
public partial struct FStructSerializerTestStruct {
// StructSerializerTestStruct
	public FStructSerializerNumericTestStruct Numerics;
	public FStructSerializerBooleanTestStruct Booleans;
	public FStructSerializerObjectTestStruct Objects;
	public FStructSerializerBuiltinTestStruct Builtins;
	public FStructSerializerArrayTestStruct Arrays;
	public FStructSerializerMapTestStruct Maps;
	public FStructSerializerSetTestStruct Sets;
	public FStructSerializerLWCTypesTest LWCTypes;
}
