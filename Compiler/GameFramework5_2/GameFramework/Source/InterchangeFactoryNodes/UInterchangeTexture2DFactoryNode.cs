#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ns UE::Interchange</summary>
[CppInclude("InterchangeTexture2DFactoryNode.h")]
public partial class UInterchangeTexture2DFactoryNode : UInterchangeTextureFactoryNode {
	public static UClass StaticClass() {return default;}
	///<summary>Return false if the Attribute was not set previously.</summary>
	public  bool GetCustomAddressX(TextureAddress AttributeValue) { return default; }
	///<summary>SetCustomAddressX</summary>
	public  bool SetCustomAddressX(TextureAddress AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Return false if the Attribute was not set previously.</summary>
	public  bool GetCustomAddressY(TextureAddress AttributeValue) { return default; }
	///<summary>SetCustomAddressY</summary>
	public  bool SetCustomAddressY(TextureAddress AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	///<summary>Get the source blocks for the texture</summary>
	public  TMap<int,string> GetSourceBlocks() { return default; }
	///<summary>Set the source blocks</summary>
	public  void SetSourceBlocks(TMap<int,string> InSourceBlocks) {}
	///<summary>Get a source block from the texture</summary>
	public  bool GetSourceBlockByCoordinates(int X,int Y,string OutSourceFile) { return default; }
	///<summary>Get a source block from the texture</summary>
	public  bool GetSourceBlock(int BlockIndex,string OutSourceFile) { return default; }
	///<summary>Set a source block for the texture</summary>
	public  void SetSourceBlockByCoordinates(int X,int Y,string InSourceFile) {}
	///<summary>Set a source block for the texture</summary>
	public  void SetSourceBlock(int BlockIndex,string InSourceFile) {}
}
