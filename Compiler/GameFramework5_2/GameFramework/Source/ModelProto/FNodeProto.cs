#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level 3 - FNodeProto</summary>
[CppInclude("ModelProto.h")]
public partial struct FNodeProto {
	public TArray<string> Input;
	public TArray<string> Output;
	public string Name;
	public string OperatorType;
	public string Domain;
	public TArray<FAttributeProto> Attribute;
	public string DocString;
}
