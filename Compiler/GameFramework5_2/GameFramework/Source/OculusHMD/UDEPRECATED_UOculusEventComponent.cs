namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusEventComponent.h")]
public partial class UDEPRECATED_UOculusEventComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>FOculusDisplayRefreshRateChangedEventDelegate</summary>
	public void FOculusDisplayRefreshRateChangedEventDelegate(float fromRefreshRate,float toRefreshRate) {}
	///<summary>OculusDisplayRefreshRateChanged</summary>
	public FOculusDisplayRefreshRateChangedEventDelegate OculusDisplayRefreshRateChanged;
}
