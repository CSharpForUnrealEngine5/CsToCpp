namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory for creating volume texture</summary>
[CppInclude("Factories/VolumeTextureFactory.h")]
public partial class UVolumeTextureFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>An initial texture to assign to the newly created volume texture</summary>
	public UTexture2D InitialTexture;
}
