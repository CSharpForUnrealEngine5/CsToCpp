#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendLiteral.h")]
///<summary>Represents the serialized version of variant literal types.</summary>
public partial struct FMetasoundFrontendLiteral {
// MetasoundFrontendLiteral
	public EMetasoundFrontendLiteralType Type;
	public int AsNumDefault;
	public TArray<bool> AsBoolean;
	public TArray<int> AsInteger;
	public TArray<float> AsFloat;
	public TArray<string> AsString;
	public TArray<UObject> AsUObject;
}
