namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the serialized version of variant literal types.</summary>
[CppInclude("MetasoundFrontendLiteral.h")]
public partial struct FMetasoundFrontendLiteral {
	public EMetasoundFrontendLiteralType Type;
	public int AsNumDefault;
	public TArray<bool> AsBoolean;
	public TArray<int> AsInteger;
	public TArray<float> AsFloat;
	public TArray<string> AsString;
	public TArray<UObject> AsUObject;
}
