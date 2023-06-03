using _ColorGame.Scripts.GamePlay.Buttons.ButtonStates;
using _ColorGame.Scripts.GamePlay.GameManagement;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ConfigInstaller", menuName = "Installers/ConfigInstaller")]
public class ConfigInstaller : ScriptableObjectInstaller<ConfigInstaller>
{
    [SerializeField] private GameConfig _gameConfig;
    [SerializeField] private ButtonStatesConfig _buttonStatesConfig;
    public override void InstallBindings()
    {
        // Install configurations bindings
        Container.Bind<GameConfig>().FromInstance(_gameConfig).AsSingle();
        Container.Bind<ButtonStatesConfig>().FromInstance(_buttonStatesConfig).AsSingle();
    }
}