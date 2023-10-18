namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorTutorial.h")]
///<summary>The type of tutorial content to display</summary>
[CppEnumInNamespace]
public enum ETutorialContent {
	None=0,
	Text=1,
	UDNExcerpt=2,
	RichText=3,
}
