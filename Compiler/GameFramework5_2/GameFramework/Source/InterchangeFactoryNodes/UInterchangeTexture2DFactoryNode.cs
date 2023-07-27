#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeTexture2DFactoryNode.h")]
///<summary>ns UE::Interchange</summary>
public partial class UInterchangeTexture2DFactoryNode : UInterchangeTextureFactoryNode {
// InterchangeTexture2DFactoryNode
	public  bool GetCustomAddressX(TextureAddress AttributeValue) { return default; }
	public  bool SetCustomAddressX(TextureAddress AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public  bool GetCustomAddressY(TextureAddress AttributeValue) { return default; }
	public  bool SetCustomAddressY(TextureAddress AttributeValue,bool bAddApplyDelegate/*=true*/) { return default; }
	public  TMap<int,string> GetSourceBlocks() { return default; }
	public  void SetSourceBlocks(TMap<int,string> InSourceBlocks) {}
	public  bool GetSourceBlockByCoordinates(int X,int Y,string OutSourceFile) { return default; }
	public  bool GetSourceBlock(int BlockIndex,string OutSourceFile) { return default; }
	public  void SetSourceBlockByCoordinates(int X,int Y,string InSourceFile) {}
	public  void SetSourceBlock(int BlockIndex,string InSourceFile) {}
}
