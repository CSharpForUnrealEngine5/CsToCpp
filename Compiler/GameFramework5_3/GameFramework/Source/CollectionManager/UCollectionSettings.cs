namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CollectionSettings.h")]
public partial class UCollectionSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>When enabled, Shared and Private collections will automatically commit their changes to source control</summary>
	public bool bAutoCommitOnSave;
}
