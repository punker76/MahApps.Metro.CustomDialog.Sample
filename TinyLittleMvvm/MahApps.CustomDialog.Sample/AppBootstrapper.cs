using Autofac;
using TinyLittleMvvm;

namespace MahApps.CustomDialog.Sample
{
    public interface IShell
    {
    }

    public class AppBootstrapper : BootstrapperBase<IShell>
    {
        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);

            builder.RegisterType<MainViewModel>().AsSelf().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<MainView>().SingleInstance();

            builder.RegisterType<ChoiceDialogView>().InstancePerDependency().AsSelf();
            builder.RegisterType<ChoiceDialogViewModel>().InstancePerDependency().AsSelf();
        }
    }
}