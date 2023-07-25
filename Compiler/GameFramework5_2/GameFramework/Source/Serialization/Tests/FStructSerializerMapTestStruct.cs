#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/StructSerializerTestTypes.h")]
///<summary>Test structure for map properties.</summary>
public partial struct FStructSerializerMapTestStruct {
// StructSerializerMapTestStruct
	public TMap<int,string> IntToStr;
	public TMap<string,string> StrToStr;
	public TMap<string,FVector> StrToVec;
	public TMap<string,FStructSerializerBuiltinTestStruct> StrToStruct;
}
