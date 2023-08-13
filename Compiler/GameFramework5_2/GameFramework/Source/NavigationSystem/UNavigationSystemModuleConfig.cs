namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UNavigationSystemModuleConfig</summary>
[CppInclude("NavigationSystem.h")]
public partial class UNavigationSystemModuleConfig : UNavigationSystemConfig {
	public static UClass StaticClass() {return default;}
	///<summary>Whether at game runtime we expect any kind of dynamic navigation generation</summary>
	public bool bStrictlyStatic;
	///<summary>bCreateOnClient</summary>
	public bool bCreateOnClient;
	///<summary>bAutoSpawnMissingNavData</summary>
	public bool bAutoSpawnMissingNavData;
	///<summary>bSpawnNavDataInNavBoundsLevel</summary>
	public bool bSpawnNavDataInNavBoundsLevel;
}
