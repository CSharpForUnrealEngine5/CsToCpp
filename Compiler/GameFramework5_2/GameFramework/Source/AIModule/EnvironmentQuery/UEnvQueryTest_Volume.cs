#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Tests/EnvQueryTest_Volume.h")]
public partial class UEnvQueryTest_Volume : UEnvQueryTest {
	///<summary>Context that populates a list of Actors derived from AVolume to test against</summary>
	public UClass VolumeContext;
	///<summary>If VolumeContext is null, AVolume Class will be used to populate a list of AVolume to test against</summary>
	public UClass VolumeClass;
	///<summary>If bDoComplexVolumeTest is set, it will use a full volume physic test (not only a bounding box test)</summary>
	public bool bDoComplexVolumeTest;
}
