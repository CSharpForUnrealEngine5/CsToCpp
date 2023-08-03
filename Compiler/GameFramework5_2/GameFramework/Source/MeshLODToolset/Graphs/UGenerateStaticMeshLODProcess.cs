#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graphs/GenerateStaticMeshLODProcess.h")]
public partial class UGenerateStaticMeshLODProcess : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SourceStaticMesh</summary>
	public UStaticMesh SourceStaticMesh;
	///<summary>This list is for accumulating derived UTexture2D&#39;s created during WriteDerivedTextures(). We have to</summary>
	public TSet<UTexture2D> AllDerivedTextures;
	///<summary>Derived Normal Map</summary>
	public UTexture2D DerivedNormalMapTex;
	///<summary>DerivedMultiTextureBakeResult</summary>
	public UTexture2D DerivedMultiTextureBakeResult;
}
