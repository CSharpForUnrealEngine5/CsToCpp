namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SceneComponent.h")]
///<summary>Detail mode for scene component rendering, corresponds with the integer value of UWorld::GetDetailMode()</summary>
public enum EDetailMode {
	DM_Low=0,
	DM_Medium=1,
	DM_High=2,
	DM_Epic=3,
	DM_MAX=4,
}
