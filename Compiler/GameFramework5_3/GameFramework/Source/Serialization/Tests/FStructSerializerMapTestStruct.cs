namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for map properties.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerMapTestStruct {
	public TMap<int,string> IntToStr;
	public TMap<string,string> StrToStr;
	public TMap<string,FVector> StrToVec;
	public TMap<string,FStructSerializerBuiltinTestStruct> StrToStruct;
}
