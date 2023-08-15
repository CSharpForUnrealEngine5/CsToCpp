namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for properties of various built-in types.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerBuiltinTestStruct {
	public FGuid Guid;
	public FName Name;
	public string String;
	public FText Text;
	public FVector Vector;
	public FVector4 Vector4;
	public FRotator Rotator;
	public FQuat Quat;
	public FColor Color;
}
