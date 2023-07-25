#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Blueprint.h")]
///<summary>Struct indicating a variable in the generated class</summary>
public partial struct FBPVariableDescription {
// BPVariableDescription
	public string VarName;
	public FGuid VarGuid;
	public FEdGraphPinType VarType;
	public string FriendlyName;
	public string Category;
	public ulong PropertyFlags;
	public string RepNotifyFunc;
	public byte ReplicationCondition;
	public TArray<FBPVariableMetaDataEntry> MetaDataArray;
	public string DefaultValue;
}
