#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterBodyOceanActor.h")]
public partial class UDEPRECATED_OceanGenerator : UDEPRECATED_WaterBodyGenerator {
	public static UClass StaticClass() {return default;}
	///<summary>CollisionBoxes</summary>
	public TArray<UOceanBoxCollisionComponent> CollisionBoxes;
	///<summary>CollisionHullSets</summary>
	public TArray<UOceanCollisionComponent> CollisionHullSets;
}
