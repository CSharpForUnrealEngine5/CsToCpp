#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An actor that renders a simulated hair</summary>
[CppInclude("GroomActor.h")]
public partial class AGroomActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Strand hair component that performs simulation and rendering</summary>
	public UGroomComponent GroomComponent;
	///<summary>Billboard used to see the scene in the editor</summary>
	public UBillboardComponent SpriteComponent;
}
