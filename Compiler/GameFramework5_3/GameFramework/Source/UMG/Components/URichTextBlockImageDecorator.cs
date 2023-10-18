namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows you to setup an image decorator that can be configured</summary>
[CppInclude("Components/RichTextBlockImageDecorator.h")]
public partial class URichTextBlockImageDecorator : URichTextBlockDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>ImageSet</summary>
	public UDataTable ImageSet;
}
