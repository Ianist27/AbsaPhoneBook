using AbsaPhoneBook.Core.Interfaces;
using AbsaPhoneBook.Core.Services;
using Autofac;

namespace AbsaPhoneBook.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PhoneBookService>()
                .As<IPhoneBookService>().InstancePerLifetimeScope();
        }
    }
}
