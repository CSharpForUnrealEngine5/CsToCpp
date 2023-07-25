#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Describes if an actor can enter a low network bandwidth dormant mode</summary>
public enum ENetDormancy {
	DORM_Never=0,
	DORM_Awake=1,
	DORM_DormantAll=2,
	DORM_DormantPartial=3,
	DORM_Initial=4,
	DORM_MAX=5,
}
