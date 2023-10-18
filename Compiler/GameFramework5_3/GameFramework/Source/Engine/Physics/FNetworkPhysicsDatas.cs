namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base network physics datas that will be used by physics</summary>
[CppInclude("Physics/NetworkPhysicsComponent.h")]
public partial struct FNetworkPhysicsDatas {
	public int ServerFrame;
	public int LocalFrame;
	public int InputFrame;
}
