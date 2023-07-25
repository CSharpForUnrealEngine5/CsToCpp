using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Camera/CameraComponent.h")]
    public partial class UCameraComponent : USceneComponent {
        public bool bUsePawnControlRotation;
    }

}