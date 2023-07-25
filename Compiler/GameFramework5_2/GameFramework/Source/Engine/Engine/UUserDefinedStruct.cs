#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/UserDefinedStruct.h")]
public partial class UUserDefinedStruct : UScriptStruct {
// UserDefinedStruct
	public TWeakObjectPtr<UUserDefinedStruct> PrimaryStruct;
	public string ErrorMessage;
	public UObject EditorData;
	public byte Status;
	public FGuid Guid;
	public UStructCookedMetaData CachedCookedMetaDataPtr;
}
