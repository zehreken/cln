//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public cln.GameScoreComponent gameScore { get { return (cln.GameScoreComponent)GetComponent(GameComponentsLookup.GameScore); } }
    public bool hasGameScore { get { return HasComponent(GameComponentsLookup.GameScore); } }

    public void AddGameScore(int newValue) {
        var index = GameComponentsLookup.GameScore;
        var component = CreateComponent<cln.GameScoreComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameScore(int newValue) {
        var index = GameComponentsLookup.GameScore;
        var component = CreateComponent<cln.GameScoreComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameScore() {
        RemoveComponent(GameComponentsLookup.GameScore);
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

    static Entitas.IMatcher<GameEntity> _matcherGameScore;

    public static Entitas.IMatcher<GameEntity> GameScore {
        get {
            if (_matcherGameScore == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameScore);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameScore = matcher;
            }

            return _matcherGameScore;
        }
    }
}