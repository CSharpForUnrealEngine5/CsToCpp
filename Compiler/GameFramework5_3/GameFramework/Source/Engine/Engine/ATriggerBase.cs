namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An actor used to generate collision events (begin/end overlap) in the level.</summary>
[CppInclude("Engine/TriggerBase.h")]
public partial class ATriggerBase : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Shape component used for collision</summary>
	public UShapeComponent CollisionComponent;
	///<summary>Billboard used to see the trigger in the editor</summary>
	public UBillboardComponent SpriteComponent;
}
