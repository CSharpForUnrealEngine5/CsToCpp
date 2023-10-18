namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response from a Show Import Task query on OneSky</summary>
[CppInclude("OneSkyLocalizationServiceResponseTypes.h")]
public partial struct FOneSkyShowImportTaskResponse {
	public FOneSkyShowImportTaskResponseMeta meta;
	public FOneSkyShowImportTaskResponseData data;
}
