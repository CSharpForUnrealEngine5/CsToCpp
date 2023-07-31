#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxAnimSequenceImportData.h")]
///<summary>Animation length type when importing</summary>
public enum EFBXAnimationLengthImportType {
	FBXALIT_ExportedTime=0,
	FBXALIT_AnimatedKey=1,
	FBXALIT_SetRange=2,
	FBXALIT_MAX=3,
}
