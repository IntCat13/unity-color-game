using _ColorGame.Scripts.GamePlay.Buttons;
using _ColorGame.Scripts.GamePlay.GameManagement;
using _ColorGame.Scripts.GamePlay.GameManagement.Timer;
using UnityEngine;
using Zenject;

// This class is responsible for installing all core bindings in the game
public class CoreInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //Install GamePlay bindings
        Container.Bind<GameEvents>().FromComponentInHierarchy().AsSingle();
        Container.Bind<GameTimer>().FromComponentInHierarchy().AsSingle();
        Container.Bind<ScoreCounter>().FromComponentInHierarchy().AsSingle();
        
        // Install Buttons bindings
        Container.Bind<ButtonsController>().FromComponentInHierarchy().AsSingle();
        Container.Bind<ButtonsMixer>().FromComponentInHierarchy().AsSingle();
    }
}