#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCreateActorSampleTool is an example Tool that drops an empty Actor at each position the user</summary>
[CppInclude("SampleTools/CreateActorSampleTool.h")]
public partial class UCreateActorSampleTool : USingleClickTool {
	public static UClass StaticClass() {return default;}
	///<summary>Properties</summary>
	public UCreateActorSampleToolProperties Properties;
}
