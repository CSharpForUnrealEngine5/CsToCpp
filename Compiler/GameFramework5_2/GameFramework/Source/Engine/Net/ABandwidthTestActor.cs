namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This ABandwidthTestActor class is used to generate an easily controllable amount of bandwidth.</summary>
[CppInclude("Net/BandwidthTestActor.h")]
public partial class ABandwidthTestActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>BandwidthGenerator</summary>
	public FBandwidthTestGenerator BandwidthGenerator;
}
