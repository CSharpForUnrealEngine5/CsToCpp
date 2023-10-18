namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/FixturePatch/DMXAddFixturePatchMenuData.h")]
public partial class UDMXAddFixturePatchMenuData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SoftFixtureType</summary>
	public TSoftObjectPtr<UDMXEntityFixtureType> SoftFixtureType;
	///<summary>ActiveModeIndex</summary>
	public int ActiveModeIndex;
	///<summary>NumPatches</summary>
	public int NumPatches;
	///<summary>bIncrementChannelAfterPatching</summary>
	public bool bIncrementChannelAfterPatching;
}
