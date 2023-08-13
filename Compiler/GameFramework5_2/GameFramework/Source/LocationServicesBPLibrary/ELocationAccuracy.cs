namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocationServicesBPLibrary.h")]
///<summary>Enum used to determine what accuracy the Location Services should be run with. Based off the iOS kCLLocationAccuracy</summary>
public enum ELocationAccuracy {
	LA_ThreeKilometers=0,
	LA_OneKilometer=1,
	LA_HundredMeters=2,
	LA_TenMeters=3,
	LA_Best=4,
	LA_Navigation=5,
}
