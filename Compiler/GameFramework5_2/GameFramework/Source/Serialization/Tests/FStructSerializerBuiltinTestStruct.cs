#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Test structure for properties of various built-in types.</summary>
[CppInclude("Tests/StructSerializerTestTypes.h")]
public partial struct FStructSerializerBuiltinTestStruct {
	public FGuid Guid;
	public string Name;
	public string String;
	public string Text;
	public FVector Vector;
	public FVector4 Vector4;
	public FRotator Rotator;
	public FQuat Quat;
	public FColor Color;
}
