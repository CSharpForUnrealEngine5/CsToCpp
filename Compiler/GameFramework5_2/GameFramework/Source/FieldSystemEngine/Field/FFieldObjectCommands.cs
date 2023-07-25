#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Field Commands container that will be stored in the construction script</summary>
public partial struct FFieldObjectCommands {
// FieldObjectCommands
	public TArray<string> TargetNames;
	public TArray<UFieldNodeBase> RootNodes;
	public TArray<UFieldSystemMetaData> MetaDatas;
}
