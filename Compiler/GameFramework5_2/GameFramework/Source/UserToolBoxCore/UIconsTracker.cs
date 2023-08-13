namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IconsTracker.h")]
public partial class UIconsTracker : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>IconFolderInfos</summary>
	public TArray<FIconFolderInfo> IconFolderInfos;
	///<summary>PrefixId</summary>
	public string PrefixId;
}
