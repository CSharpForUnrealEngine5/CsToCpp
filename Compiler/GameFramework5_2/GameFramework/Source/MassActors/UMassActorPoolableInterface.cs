namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassActorPoolableInterface.h")]
public partial class UMassActorPoolableInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>CanBePooled</summary>
	public bool CanBePooled() { return default; }
	///<summary>PrepareForPooling</summary>
	public void PrepareForPooling() {}
	///<summary>PrepareForGame</summary>
	public void PrepareForGame() {}
}
