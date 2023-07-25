using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("GameFramework/MovementComponent.h")]
    public partial class UMovementComponent : UActorComponent {
        public USceneComponent UpdatedComponent;
    }

}