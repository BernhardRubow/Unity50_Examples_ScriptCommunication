using System.ComponentModel;
using UnityEngine;
using Zenject;

public class SceneContextInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<INvpEventModel>().To<NvpEventModel>().AsSingle();
    }
}