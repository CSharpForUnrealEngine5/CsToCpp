namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BuoyancyTypes.h")]
public partial struct FSphericalPontoon {
	public FName CenterSocket;
	public FVector RelativeLocation;
	public float Radius;
	public bool bFXEnabled;
	public FVector LocalForce;
	public FVector CenterLocation;
	public FQuat SocketRotation;
	public FVector Offset;
	public float WaterHeight;
	public float WaterDepth;
	public float ImmersionDepth;
	public FVector WaterPlaneLocation;
	public FVector WaterPlaneNormal;
	public FVector WaterSurfacePosition;
	public FVector WaterVelocity;
	public int WaterBodyIndex;
	public bool bIsInWater;
	public UWaterBodyComponent CurrentWaterBodyComponent;
}
