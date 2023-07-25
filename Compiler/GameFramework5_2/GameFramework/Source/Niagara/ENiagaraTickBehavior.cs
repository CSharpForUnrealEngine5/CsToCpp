#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTickBehaviorEnum.h")]
///<summary>Niagara ticking behaviour</summary>
public enum ENiagaraTickBehavior {
	UsePrereqs=0,
	UseComponentTickGroup=1,
	ForceTickFirst=2,
	ForceTickLast=3,
}
