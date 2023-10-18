namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that records level visibilitiy</summary>
[CppInclude("TakeRecorderLevelVisibilitySource.h")]
public partial class UTakeRecorderLevelVisibilitySourceSettings : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the recorded level visibility track name</summary>
	public FText LevelVisibilityTrackName;
}
