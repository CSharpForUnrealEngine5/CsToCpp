namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for set properties.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerSetTestStruct {
	public TSet<string> StrSet;
	public TSet<int> IntSet;
	public TSet<string> NameSet;
	public TSet<FStructSerializerBuiltinTestStruct> StructSet;
}
