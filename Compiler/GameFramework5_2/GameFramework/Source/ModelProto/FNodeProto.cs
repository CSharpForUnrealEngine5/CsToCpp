#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelProto.h")]
///<summary>Level 3 - FNodeProto</summary>
public partial struct FNodeProto {
// NodeProto
	public TArray<string> Input;
	public TArray<string> Output;
	public string Name;
	public string OperatorType;
	public string Domain;
	public TArray<FAttributeProto> Attribute;
	public string DocString;
}
