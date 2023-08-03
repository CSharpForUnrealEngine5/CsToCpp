#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UserToolBoxSubsystem.h")]
public partial class UUserToolboxSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>RegisterTabData</summary>
	public  void RegisterTabData() {}
	///<summary>PickAnIcon</summary>
	public  bool PickAnIcon(string OutValue) { return default; }
	///<summary>RegisteredTabs</summary>
	public TMap<string,UUserToolBoxBaseTab> RegisteredTabs;
	///<summary>RefreshIcons</summary>
	public  void RefreshIcons() {}
}
