namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/UserDefinedStruct.h")]
public partial class UUserDefinedStruct : UScriptStruct {
	public static UClass StaticClass() {return default;}
	///<summary>The original struct, when current struct isn&#39;t a temporary duplicate, the field should be null</summary>
	public TWeakObjectPtr<UUserDefinedStruct> PrimaryStruct;
	///<summary>ErrorMessage</summary>
	public string ErrorMessage;
	///<summary>EditorData</summary>
	public UObject EditorData;
	///<summary>Status of this struct, outside of the editor it is assumed to always be UpToDate</summary>
	public EUserDefinedStructureStatus Status;
	///<summary>Uniquely identifies this specific user struct</summary>
	public FGuid Guid;
	///<summary>CachedCookedMetaDataPtr</summary>
	public UStructCookedMetaData CachedCookedMetaDataPtr;
}
