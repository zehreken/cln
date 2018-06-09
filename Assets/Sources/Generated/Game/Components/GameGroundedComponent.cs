//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly cln.GroundedComponent groundedComponent = new cln.GroundedComponent();

    public bool isGrounded {
        get { return HasComponent(GameComponentsLookup.Grounded); }
        set {
            if (value != isGrounded) {
                var index = GameComponentsLookup.Grounded;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : groundedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGrounded;

    public static Entitas.IMatcher<GameEntity> Grounded {
        get {
            if (_matcherGrounded == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Grounded);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGrounded = matcher;
            }

            return _matcherGrounded;
        }
    }
}