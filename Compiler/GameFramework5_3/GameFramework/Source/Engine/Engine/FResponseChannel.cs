namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes response for a single collision response channel</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FResponseChannel {
	public FName Channel;
	public ECollisionResponse Response;
}
