namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UserDefinedStructure/UserDefinedStructEditorData.h")]
public partial class UUserDefinedStructEditorData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>the property is used to generate an uniqe name id for member variable</summary>
	public uint UniqueNameId;
	///<summary>VariablesDescriptions</summary>
	public TArray<FStructVariableDescription> VariablesDescriptions;
	///<summary>ToolTip</summary>
	public string ToolTip;
}
