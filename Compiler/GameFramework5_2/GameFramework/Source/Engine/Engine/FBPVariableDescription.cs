namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct indicating a variable in the generated class</summary>
[CppInclude("Engine/Blueprint.h")]
public partial struct FBPVariableDescription {
	public string VarName;
	public FGuid VarGuid;
	public FEdGraphPinType VarType;
	public string FriendlyName;
	public FText Category;
	public ulong PropertyFlags;
	public string RepNotifyFunc;
	public ELifetimeCondition ReplicationCondition;
	public TArray<FBPVariableMetaDataEntry> MetaDataArray;
	public string DefaultValue;
}
