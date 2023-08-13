namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Serializes source control window settings.</summary>
[CppInclude("SourceControlSettings.h")]
public partial class USourceControlSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bShowAssetTypeColumn</summary>
	public bool bShowAssetTypeColumn;
	///<summary>bShowAssetLastModifiedTimeColumn</summary>
	public bool bShowAssetLastModifiedTimeColumn;
	///<summary>bShowAssetCheckedOutByColumn</summary>
	public bool bShowAssetCheckedOutByColumn;
	///<summary>bEnableSubmitContentMenuAction</summary>
	public bool bEnableSubmitContentMenuAction;
}
