#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SceneOutlinerConfig.h")]
public partial class UOutlinerConfig : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Outliners</summary>
	public TMap<string,FSceneOutlinerConfig> Outliners;
}
