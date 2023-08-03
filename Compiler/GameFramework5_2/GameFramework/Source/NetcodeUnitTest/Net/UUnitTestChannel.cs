#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A net channel for overriding the implementation of traditional net channels,</summary>
[CppInclude("Net/UnitTestChannel.h")]
public partial class UUnitTestChannel : UChannel {
	public static UClass StaticClass() {return default;}
	///<summary>The minimal client which may require received bunch notifications</summary>
	public UMinimalClient MinClient;
}
