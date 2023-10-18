namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Springs.h")]
public partial struct FSpring {
	public FVector LocalPosition;
	public FVector LocalDirection;
	public ECollisionChannel TraceChannel;
	public float Stiffness;
	public float DampingStrength;
	public float RaycastLength;
	public float NaturalLength;
}
