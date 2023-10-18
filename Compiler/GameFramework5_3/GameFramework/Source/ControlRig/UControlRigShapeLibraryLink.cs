namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Namespaced user data which provides access to a linked shape library</summary>
[CppInclude("ControlRigAssetUserData.h")]
public partial class UControlRigShapeLibraryLink : UNameSpacedUserData {
	public static UClass StaticClass() {return default;}
	///<summary>If assigned, the data asset link will provide access to the data asset&#39;s content.</summary>
	public UControlRigShapeLibrary ShapeLibrary;
	///<summary>GetShapeLibrary</summary>
	public UControlRigShapeLibrary GetShapeLibrary() { return default; }
	///<summary>SetShapeLibrary</summary>
	public void SetShapeLibrary(UControlRigShapeLibrary InShapeLibrary) {}
	///<summary>ShapeNames</summary>
	public TArray<FName> ShapeNames;
}
