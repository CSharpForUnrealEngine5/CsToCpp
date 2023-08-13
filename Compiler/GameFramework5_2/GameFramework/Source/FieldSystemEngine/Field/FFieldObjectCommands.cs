namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Field Commands container that will be stored in the construction script</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial struct FFieldObjectCommands {
	public TArray<string> TargetNames;
	public TArray<UFieldNodeBase> RootNodes;
	public TArray<UFieldSystemMetaData> MetaDatas;
}
