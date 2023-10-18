namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Store struct used to extend collision-based targeting tasks providing extra data from outside</summary>
[CppInclude("Tasks/CollisionQueryTaskData.h")]
public partial struct FCollisionQueryTaskData {
	public TArray<AActor> IgnoredActors;
}
