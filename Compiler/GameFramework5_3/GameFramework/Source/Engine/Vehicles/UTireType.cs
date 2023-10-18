namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DEPRECATED - Only used to allow conversion to new TireConfig in PhysXVehicles plugin</summary>
[CppInclude("Vehicles/TireType.h")]
public partial class UTireType : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>FrictionScale</summary>
	public float FrictionScale;
}
