namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset user data used to supply curve meta data for specific assets</summary>
[CppInclude("Animation/AnimCurveMetadata.h")]
public partial class UAnimCurveMetaData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>Map of name -&gt; metadata</summary>
	public TMap<FName,FCurveMetaData> CurveMetaData;
}
