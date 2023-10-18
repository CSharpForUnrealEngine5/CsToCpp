namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor used when running ICVFX perf tests. For every test location, the display cluster root actor will be moved to this location and perf data will be connected for a minute.</summary>
[CppInclude("ICVFXTestLocation.h")]
public partial class AICVFXTestLocation : ACameraActor {
	public static UClass StaticClass() {return default;}
}
